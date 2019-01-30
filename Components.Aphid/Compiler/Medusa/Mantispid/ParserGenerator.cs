using Components;
using Components.Aphid.Compiler;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.TypeSystem;
using LLex;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mantispid
{
    ////////////////////////////////////////////////////////////////
    // Todo:
    // * Add EBNF style macros/funcs/custom ops
    // * Implement more types using Aphid-to-C#
    //   
    //   typedef IEnumerable iter;
    //   typedef AphidExpression expression;
    //   typedef iter expression block;
    //   // Infer interface from hungarian notation
    //   type IParentNode block GetChildren();
    //   // ->
    //   // public interface IParentNode
    //   // {
    //   /    IEnumerable<AphidExpression> GetChildren();
    //   // }
    public class ParserGenerator
    {
        private string[] _ruleNames;

        private RuleTypeTable _ruleTypes = new RuleTypeTable();

        private ParserGeneratorConfig _config;

        private AphidObject _scope = AphidObject.Scope();

        private string[] _tokenTypes;

        private void EnterChildScope() => _scope = AphidObject.Scope(_scope);

        private void LeaveChildScope() => _scope = _scope.Parent;

        private static BinaryOperatorExpression[] GetRules(List<AphidExpression> nodes)
        {
            return nodes
                .Where(x => x.Type == AphidExpressionType.BinaryOperatorExpression)
                .Cast<BinaryOperatorExpression>()
                .Where(x =>
                    x.LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
                    x.RightOperand.Type == AphidExpressionType.FunctionExpression)
                .ToArray();
        }

        public string Generate(List<AphidExpression> nodes, string code)
        {
            ParseDirectives(nodes);
            var lexer = GenerateLexer(nodes, code);
            ParseRuleStructs(nodes);
            nodes = new PlusEqualMutator().MutateRecursively(nodes);
            var rules = GetRules(nodes);
            _ruleNames = GetRuleNames(nodes).ToArray();
            var mutator = new TypeInferenceMutator(_config);

            foreach (var r in rules)
            {
                nodes.Remove(r);
            }

            do
            {
                rules = rules
                    .Select(x => new BinaryOperatorExpression(
                        x.LeftOperand,
                        x.Operator,
                        new FunctionExpression(
                            x.RightOperand.ToFunction().Args,
                            mutator.MutateRecursively(x.RightOperand.ToFunction().Body))))
                    .ToArray();
            }
            while (mutator.HasMutated);

            nodes.AddRange(rules);
            var declMutator = new DeclarativeStatementMutator(_tokenTypes, _ruleNames);
            nodes = declMutator.Mutate(nodes);
            nodes = AddIndexTracking(nodes);
            var ruleTypeBuilder = new RuleTypeBuilder(_config, _ruleTypes.Select(x => x.Value));
            var typeClasses = ruleTypeBuilder.CreateRuleTypeClasses();
            var enumBuilder = new EnumBuilder(_config.BaseClass, _ruleTypes.Select(x => x.Key));
            var enumDecl = enumBuilder.CreateEnum();

            var ns = new CodeNamespace(
                string.Join(".", _config.Namespace.Concat(new[] { ParserName.Parser })));

            ns.Imports.Add(new CodeNamespaceImport(
                string.Join(".", _config.Namespace.Concat(new[] { ParserName.Lexer }))));

            ns.Imports.Add(new CodeNamespaceImport("System.Linq"));
            ns.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            ns.Types.Add(enumDecl);
            ns.Types.AddRange(typeClasses);

            var parserType = new CodeTypeDeclaration(_config.ParserClass)
            {
                IsPartial = true,
            };

            parserType.Members.Add(GenerateContextField());
            parserType.Members.AddRange(nodes.Select(Generate).Where(x => x != null).ToArray());
            ns.Types.Add(parserType);

            var str = CSharpHelper.GenerateCode(ns);

            return str + "\r\n\r\n" + lexer;
        }

        private static List<AphidExpression> AddIndexTracking(List<AphidExpression> nodes)
        {
            var ids = nodes
                .Select(x => x.ToBinaryOperator().LeftOperand.ToIdentifier())
                .Select(ParserIdentifier.FromIdentifierExpression)
                .ToArray();

            var nonListIds = ids.Where(x => !x.IsList).Select(x => x.Name).ToArray();

            return new IndexTrackingMutator(nonListIds).Mutate(nodes);
        }

        private string GenerateLexer(List<AphidExpression> nodes, string code)
        {
            var lexerCall = nodes.SingleOrDefault(x =>
                x.Type == AphidExpressionType.CallExpression &&
                x.ToCall().FunctionExpression.Type == AphidExpressionType.IdentifierExpression &&
                x.ToCall().FunctionExpression.ToIdentifier().Identifier == "Lexer");

            if (lexerCall == null)
            {
                throw new InvalidOperationException();
            }

            if (!(lexerCall.ToCall().Args.SingleOrDefault() is ObjectExpression lexerObj))
            {
                throw new InvalidOperationException();
            }

            nodes.Remove(lexerCall);
            var ast = new List<AphidExpression>();

            var initKvp = lexerObj.Pairs.SingleOrDefault(x =>
                x.LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
                x.LeftOperand.ToIdentifier().Identifier == "init");

            if (initKvp != null)
            {
                if (!(initKvp.RightOperand is FunctionExpression initFunc))
                {
                    throw new InvalidOperationException();
                }

                ast.AddRange(initFunc.Body);
            }

            ast.Add(new UnaryOperatorExpression(AphidTokenType.retKeyword, lexerObj)
                .WithPositionFrom(lexerObj));

            var interpreter = new AphidInterpreter();
            interpreter.CurrentScope.Add("nodes", AphidObject.Scalar(nodes));
            interpreter.Interpret(ast);
            var lexerCode = AlxFile.From(interpreter.GetReturnValue());

            var tokenTypeEnum = Regex.Match(
                lexerCode,
                @"public\s+enum\s+" + _config.TokenType + @"(.|\s)*?\{((.|\s)*?)\}");

            if (!tokenTypeEnum.Success)
            {
                throw new InvalidOperationException(string.Format(
                    "[Parser Generation] Could not find token type: {0}",
                    _config.TokenType));
            }

            _tokenTypes = tokenTypeEnum.Groups[2].Value
                .Split(new[] { '\r', '\n', ',', }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Where(x => x.Length > 0)
                .ToArray();

            return lexerCode;
        }

        private void ParseDirectives(List<AphidExpression> nodes)
        {
            _config = new ParserGeneratorConfig(
                ParseDirective(nodes, ParserGeneratorDirective.TokenAttribute),
                ParseDirective(nodes, ParserGeneratorDirective.BaseAttribute),
                ParseDirective(nodes, ParserGeneratorDirective.NodeAttribute),
                ParseDirectiveArray(nodes, ParserGeneratorDirective.NamespaceAttribute),
                ParseDirective(nodes, ParserGeneratorDirective.ParserAttribute),
                ParseBooleanDirective(nodes, ParserGeneratorDirective.MutableAttribute));
        }

        private static string ParseDirective(List<AphidExpression> nodes, string directive)
        {
            var exp = nodes
                .OfType<IdentifierExpression>()
                .SingleOrDefault(x => x.Attributes.Count == 1 && x.Attributes[0].Identifier == directive);

            nodes.Remove(exp);

            return exp?.Identifier;
        }

        private string[] ParseDirectiveArray(List<AphidExpression> nodes, string directive)
        {
            var scalarVal = ParseDirective(nodes, directive);

            if (scalarVal != null)
            {
                return new[] { scalarVal };
            }

            var idSeq = nodes
                .OfType<BinaryOperatorExpression>()
                .Where(x => x.Operator == AphidTokenType.MemberOperator)
                .Select(x => new
                {
                    Expression = x,
                    Values = Flatten(x)
                })
                .SingleOrDefault(x =>
                    x.Values.All(y => y.Type == AphidExpressionType.IdentifierExpression) &&
                    ((IdentifierExpression)x.Values[0]).Attributes.Count == 1 &&
                    ((IdentifierExpression)x.Values[0]).Attributes[0].Identifier == directive);

            if (idSeq == null)
            {
                return Array.Empty<string>();
            }

            nodes.Remove(idSeq.Expression);

            return idSeq.Values
                .Cast<IdentifierExpression>()
                .Select(x => x.Identifier)
                .ToArray();
        }

        private static bool ParseBooleanDirective(List<AphidExpression> nodes, string directive)
        {
            var exp = nodes
                .OfType<IdentifierExpression>()
                .SingleOrDefault(x => x.Attributes.Count == 0 && x.Identifier == directive);

            if (exp == null)
            {
                return false;
            }

            nodes.Remove(exp);

            return true;
        }

        private AphidExpression[] Flatten(AphidExpression exp)
        {
            var expressions = new List<AphidExpression>();

            switch (exp.Type)
            {
                case AphidExpressionType.BinaryOperatorExpression:
                    var binOpExp = (BinaryOperatorExpression)exp;
                    expressions.AddRange(Flatten(binOpExp.LeftOperand));
                    expressions.AddRange(Flatten(binOpExp.RightOperand));
                    break;

                default:
                    expressions.Add(exp);
                    break;
            }

            return expressions.ToArray();
        }

        private ParserIdentifier ParseRuleProperty(IdentifierExpression propertyId)
        {
            var prop = AphidAttributeParser.Parse<ParserIdentifier>(propertyId);
            prop.Name = propertyId.Identifier;

            if (prop.Type == null)
            {
                prop.Type = _config.BaseClass;
            }

            return prop;
        }

        private void ParseRuleStructs(List<AphidExpression> nodes)
        {
            var typeExpressions = nodes
                .OfType<BinaryOperatorExpression>()
                .Where(x =>
                    x.Operator == AphidTokenType.AssignmentOperator &&
                    x.LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
                    x.RightOperand.Type == AphidExpressionType.ObjectExpression)
                .ToArray();

            foreach (var t in typeExpressions)
            {
                nodes.Remove(t);
            }

            var types = typeExpressions
                .Select(x => new
                {
                    Name = ((IdentifierExpression)x.LeftOperand),
                    Properties = ((ObjectExpression)x.RightOperand).Pairs
                        .Select(y => ParseRuleProperty((IdentifierExpression)y.LeftOperand))
                        .OrderBy(y => y.IsOptional)
                        .ToArray()
                })
                .Select(x => new RuleStruct(
                    x.Name.Identifier,
                    x.Name.Attributes.Count > 0 ? x.Name.Attributes.Single().Identifier : _config.BaseClass,
                    x.Properties))
                .ToArray();

            foreach (var t in types)
            {
                _ruleTypes.Add(t);
            }
        }

        private static CodeMethodInvokeExpression GetNextToken() => CodeHelper.Invoke("NextToken");

        private static string[] GetRuleNames(List<AphidExpression> nodes)
        {
            return nodes
                .OfType<BinaryOperatorExpression>()
                .Where(x =>
                    x.Operator == AphidTokenType.AssignmentOperator &&
                    x.LeftOperand.Type == AphidExpressionType.IdentifierExpression)
                .Select(x => ((IdentifierExpression)x.LeftOperand).Identifier)
                .ToArray();
        }

        private ReferenceType ResolveType(string typeName)
        {
            return _ruleNames.Contains(typeName) ? ReferenceType.RuleDeclaration :
                _ruleTypes.ContainsKey(typeName) ? ReferenceType.RuleClass :
                ReferenceType.TokenType;
        }

        private CodeMemberField GenerateContextField()
        {
            return new CodeMemberField(
                CodeHelper.TypeRef(_config.ExpressionContextClass),
                ParserName.ContextField)
            {
                Attributes = MemberAttributes.Private,
            };
        }

        private CodeMemberMethod Generate(AphidExpression node)
        {
            switch (node.Type)
            {
                case AphidExpressionType.BinaryOperatorExpression:
                    return Generate((BinaryOperatorExpression)node);

                default:
                    throw new NotImplementedException();
            }
        }

        private CodeMemberMethod Generate(BinaryOperatorExpression node)
        {
            switch (node.Operator)
            {
                case AphidTokenType.AssignmentOperator:

                    switch (node.RightOperand.Type)
                    {
                        case AphidExpressionType.FunctionExpression:
                            return GenerateImperativeMethod(node);

                        default:
                            throw new NotImplementedException();
                        //return GenerateParseRuleFunction(node);
                    }

                default:
                    throw new NotImplementedException();
            }
        }

        private CodeMemberMethod GenerateImperativeMethod(BinaryOperatorExpression node)
        {
            _scope.Clear();

            if (node.LeftOperand.Type != AphidExpressionType.IdentifierExpression)
            {
                throw new NotImplementedException();
            }

            var funcId = (IdentifierExpression)node.LeftOperand;
            var func = (FunctionExpression)node.RightOperand;

            CodeStatement[] body;

            if (func.Body.Count == 0)
            {
                return null;
                //return new CodeStatementCollection();
#pragma warning disable CS0162 // Unreachable code detected
                body = Array.Empty<CodeStatement>();
#pragma warning restore CS0162 // Unreachable code detected
            }
            else
            {
                body = func.Body
                    .SelectMany(x => GenerateImperativeStatement(x).OfType<CodeStatement>())
                    .ToArray();
            }

            var methodAttrs = ParseMethodAttributes(funcId);
            var typeRef = CodeHelper.TypeRef(methodAttrs.Type);

            var method = new System.CodeDom.CodeMemberMethod
            {
                Name = funcId.Identifier,
                ReturnType = methodAttrs.IsList ? ParserCode.GetListTypeRef(typeRef) : typeRef,
            };

            if (methodAttrs.IsRoot)
            {
                method.Attributes = MemberAttributes.Public | MemberAttributes.Final;
                method.Statements.Add(GenerateContextInitialization());
            }

            method.Statements.AddRange(body);

            return method;

            //var str = CSharpHelper.GenerateCode(method);

            //return new CodeStatementCollection(body);
        }

        private ParserIdentifier ParseMethodAttributes(IdentifierExpression node)
        {
            var attrs = AphidAttributeParser.Parse<ParserIdentifier>(node);

            if (attrs.Type == null)
            {
                attrs.Type = _config.BaseClass;
            }

            return attrs;
        }

        private CodeStatement GenerateContextInitialization()
        {
            return new CodeConditionStatement(
                CodeHelper.Eq(
                    CodeHelper.FieldRef(ParserName.ContextField),
                    CodeHelper.Null()),
                new [] { GenerateContextAssign() });
        }

        private CodeStatement GenerateContextAssign()
        {
            return CodeHelper.Assign(
                ParserName.ContextField,
                CodeHelper.New(CodeHelper.TypeRef(_config.ExpressionContextClass)));
        }

        private CodeStatementCollection GenerateImperativeStatement(AphidExpression node)
        {
            switch (node.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    return GenerateImperativeStatement((IdentifierExpression)node);

                case AphidExpressionType.SwitchExpression:
                    return GenerateImperativeStatement((SwitchExpression)node);

                case AphidExpressionType.UnaryOperatorExpression:
                    return GenerateImperativeStatement((UnaryOperatorExpression)node);

                case AphidExpressionType.BinaryOperatorExpression:
                    return GenerateImperativeStatement((BinaryOperatorExpression)node);

                case AphidExpressionType.CallExpression:
                    return GenerateImperativeStatement((CallExpression)node);

                case AphidExpressionType.IfExpression:
                    return GenerateImperativeStatement((IfExpression)node);

                case AphidExpressionType.WhileExpression:
                    return GenerateImperativeStatement((WhileExpression)node);

                case AphidExpressionType.DoWhileExpression:
                    return GenerateImperativeStatement((DoWhileExpression)node);

                case AphidExpressionType.BreakExpression:
                    return GenerateImperativeStatement((BreakExpression)node);

                default:
                    throw new NotImplementedException();
            }
        }

        private CodeStatementCollection GenerateImperativeStatement(IdentifierExpression node)
        {
            var parserId = ParserIdentifier.FromIdentifierExpression(node);

            if (parserId.Name != "Error")
            {
                var typeRef = CodeHelper.TypeRef(parserId.Type ?? _config.BaseClass);
                typeRef = parserId.IsList ? ParserCode.GetListTypeRef(typeRef) : typeRef;
                var init = new CodeDefaultValueExpression(typeRef);
                var varDecl = new CodeVariableDeclarationStatement(typeRef, node.Identifier, init);
                _scope.Add(node.Identifier, AphidObject.Complex());

                return new CodeStatementCollection(new[] { varDecl });
            }

            return new CodeStatementCollection(new[]
            {
                    new CodeThrowExceptionStatement(
                        new CodeObjectCreateExpression(
                            _config.ExceptionClass,
                            CodeHelper.VarRef("_currentToken")))
                });
        }

        private CodeStatementCollection GenerateImperativeStatement(UnaryOperatorExpression node)
        {
            switch (node.Operator)
            {
                case AphidTokenType.retKeyword:
                    return GenerateImperativeRetStatement(node);

                default:
                    throw new NotImplementedException();
            }
        }

        private CodeStatementCollection GenerateImperativeStatement(CallExpression node)
        {
            switch (node.FunctionExpression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var name = ((IdentifierExpression)node.FunctionExpression).Identifier;

                    switch (name)
                    {
                        case ParserGeneratorDirective.NextTokenFunc:
                            return new CodeStatementCollection(new[] { GetNextTokenStatement() });

                        case ParserGeneratorDirective.MatchFunc:
                            return new CodeStatementCollection(new[]
                            {
                                CodeHelper.Stmt(
                                    CodeHelper.Invoke(
                                        ParserGeneratorDirective.MatchFunc,
                                        GenerateImperativeExpression(node.Args.Single())))
                            });

                        default:
                            return new CodeStatementCollection(new[]
                            {
                                new CodeExpressionStatement(GenerateImperativeExpression(node))
                            });
                    }

                default:
                    var funcExp = GenerateImperativeExpression(node.FunctionExpression);

                    if (funcExp is CodePropertyReferenceExpression prop)
                    {
                        var parameters = node.Args.Select(x => GenerateImperativeExpression(x, false)).ToArray();

                        return new CodeStatementCollection(new[]
                        {
                            CodeHelper.Stmt(CodeHelper.Invoke(
                                prop.TargetObject,
                                prop.PropertyName,
                                parameters))
                        });
                    }

                    throw new NotImplementedException();
            }
        }

        private CodeStatementCollection GenerateImperativeRetStatement(UnaryOperatorExpression node)
        {
            return new CodeStatementCollection(new[]
            {
                CodeHelper.Return(GenerateImperativeExpression(node.Operand))
            });
        }

        private CodeStatementCollection GenerateImperativeStatement(BinaryOperatorExpression node)
        {
            switch (node.Operator)
            {
                case AphidTokenType.AssignmentOperator:
                    return GenerateImperativeAssignStatement(node);

                default:
                    throw new NotImplementedException();
            }
        }

        private CodeStatementCollection GenerateImperativeAssignStatement(BinaryOperatorExpression node)
        {
            //if (node.RightOperand.Type == AphidNodeType.CallExpression)
            //{
            //    var call = (CallExpression)node.RightOperand;

            //    if (call.FunctionExpression.Type == AphidNodeType.IdentifierExpression &&
            //        ((IdentifierExpression)call.FunctionExpression).Identifier == "NextToken")
            //    {
            //        var assignStatements = GenerateImperativeStatement(new BinaryOperatorExpression(
            //            node.LeftOperand,
            //            node.Operator,
            //            new IdentifierExpression(_tokenTypeId)));

            //        var statements = assignStatements
            //            .OfType<CodeStatement>()
            //            .Concat(new CodeStatement[] { GetNextTokenStatement(), })
            //            .ToArray();

            //        return new CodeStatementCollection(statements);
            //    }
            //}

            if (node.LeftOperand.Type == AphidExpressionType.IdentifierExpression)
            {
                var id = ((IdentifierExpression)node.LeftOperand).Identifier;

                if (!_scope.TryResolve(id, out var obj))
                {
                    _scope.Add(id, AphidObject.Complex());

                    return new CodeStatementCollection(new[]
                    {
                        CodeHelper.VarDecl(id, GenerateImperativeExpression(node.RightOperand))
                    });
                }
            }

            var leftExp = GenerateImperativeExpression(node.LeftOperand);
            var assignStmt = CodeHelper.Assign(leftExp, GenerateImperativeExpression(node.RightOperand));

            return new CodeStatementCollection(new[] { assignStmt });
        }

        private CodeStatementCollection GenerateImperativeStatement(IfExpression node)
        {
            var condition = GenerateImperativeExpression(node.Condition, isCondition: true);
            var trueStmts = GenerateImperativeStatements(node.Body).OfType<CodeStatement>().ToArray();

            var falseStmts = node.ElseBody != null ?
                GenerateImperativeStatements(node.ElseBody).OfType<CodeStatement>().ToArray() :
                Array.Empty<CodeStatement>();

            var stmt = new CodeConditionStatement(condition, trueStmts, falseStmts);

            return new CodeStatementCollection(new[] { stmt });
        }

        private CodeStatementCollection GenerateImperativeStatement(SwitchExpression node)
        {
            var condition = GenerateImperativeExpression(node.Expression);

            CodeConditionStatement switchStatement = null;
            CodeConditionStatement rootSwitchStatement = null;

            Action<CodeConditionStatement> setSwitchStmt = x =>
            {
                if (switchStatement != null)
                {
                    switchStatement.FalseStatements.Add(x);
                    switchStatement = x;
                }
                else
                {
                    rootSwitchStatement = switchStatement = x;
                }
            };

            foreach (var c in node.Cases)
            {
                var caseChecks = c.Cases
                    .Cast<IdentifierExpression>()
                    .Select(x => x.Identifier)
                    .Select(x => IsTokenType(x) ? (CodeExpression)GetTokenTypeRef(x) : CodeHelper.VarRef(x))
                    .Select(x => CodeHelper.BinOpExp(condition, CodeBinaryOperatorType.ValueEquality, x))
                    .ToArray();

                var exp = CodeHelper.BinOpExpJoin(caseChecks, CodeBinaryOperatorType.BooleanOr);

                var body = GenerateImperativeStatements(c.Body);

                //var body = c.Body
                //    .SelectMany(x => GenerateImperativeStatement(x).OfType<CodeStatement>())
                //    .ToArray();

                setSwitchStmt(new CodeConditionStatement(exp, body.Cast<CodeStatement>().ToArray()));
            }

            if (node.DefaultCase?.Count > 0)
            {
                if (setSwitchStmt == null)
                {
                    throw new NotImplementedException();
                }

                //var defaultStmts = node.DefaultCase
                //    .SelectMany(x => GenerateImperativeStatement(x).OfType<CodeStatement>())
                //    .ToArray();

                var defaultStmts = GenerateImperativeStatements(node.DefaultCase)
                    .OfType<CodeStatement>()
                    .ToArray();

                switchStatement.FalseStatements.AddRange(defaultStmts);
            }

            return new CodeStatementCollection(new[] { rootSwitchStatement });
        }

        private CodeStatementCollection GenerateImperativeStatement(WhileExpression node)
        {
            var whileStmt = CodeHelper.While(
                GenerateImperativeExpression(node.Condition, isCondition: true),
                GenerateImperativeStatements(node.Body).OfType<CodeStatement>().ToArray());

            return new CodeStatementCollection(new[] { whileStmt });
        }

        private CodeStatementCollection GenerateImperativeStatement(DoWhileExpression node)
        {
            var body = GenerateImperativeStatements(node.Body);

            body.Add(new CodeConditionStatement(
                CodeHelper.BinOpExp(
                    GenerateImperativeExpression(node.Condition, isCondition: true),
                    CodeBinaryOperatorType.ValueEquality,
                    CodeHelper.False()),
                new CodeSnippetStatement("break;")));

            return new CodeStatementCollection(new[]
            {
                CodeHelper.While(CodeHelper.True(), body.OfType<CodeStatement>().ToArray())
            });
        }

        private static CodeStatementCollection GenerateImperativeStatement(BreakExpression node) =>
            new CodeStatementCollection(new[] { new CodeSnippetStatement("break;") });

        private CodeStatementCollection GenerateImperativeStatements(List<AphidExpression> nodes)
        {
            EnterChildScope();

            var stmts = nodes
                .SelectMany(x => GenerateImperativeStatement(x).OfType<CodeStatement>())
                .ToArray();

            LeaveChildScope();

            return new CodeStatementCollection(stmts);
        }

        private bool IsTokenType(string name) => _tokenTypes.Contains(name);

        private CodeExpression GenerateImperativeExpression(AphidExpression node, bool isCondition = false)
        {
            switch (node.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    return GenerateImperativeExpression((IdentifierExpression)node, isCondition);

                case AphidExpressionType.CallExpression:
                    return GenerateImperativeExpression((CallExpression)node);

                case AphidExpressionType.UnaryOperatorExpression:
                    return GenerateImperativeExpression((UnaryOperatorExpression)node, isCondition);

                case AphidExpressionType.BinaryOperatorExpression:
                    return GenerateImperativeExpression((BinaryOperatorExpression)node, isCondition);

                case AphidExpressionType.BooleanExpression:
                    return GenerateImperativeExpression((BooleanExpression)node);

                case AphidExpressionType.NullExpression:
                    return CodeHelper.Null();

                case AphidExpressionType.ArrayAccessExpression:
                    return GenerateImperativeExpression((ArrayAccessExpression)node);

                case AphidExpressionType.NumberExpression:
                    return GenerateImperativeExpression((NumberExpression)node);

                case AphidExpressionType.StringExpression:
                    return CodeHelper.Value(StringParser.Parse(((StringExpression)node).Value));

                default:
                    throw new NotImplementedException();
            }
        }

        private static CodeExpression GenerateImperativeExpression(BooleanExpression node) =>
            node.Value ? CodeHelper.True() : CodeHelper.False();

        private CodeExpression GenerateImperativeExpression(IdentifierExpression node, bool isCondition = false)
        {
            switch (node.Identifier)
            {
                case ParserGeneratorDirective.CurrentTokenType:
                    return GetCurrentTokenType();

                case ParserGeneratorDirective.CurrentLexeme:
                    return GetCurrentLexeme();

                default:
                    if (IsTokenType(node.Identifier))
                    {
                        var exp = (CodeExpression)GetTokenTypeRef(node.Identifier);

                        if (!isCondition)
                        {
                            return exp;
                        }

                        return CodeHelper.BinOpExp(
                            GetCurrentTokenType(),
                            CodeBinaryOperatorType.ValueEquality,
                            exp);
                    }
                    else if (node.Attributes.Count > 0)
                    {
                        var attr = node.Attributes.Single().Identifier;

                        if (attr == "list")
                        {
                            return new CodeObjectCreateExpression(
                                ParserCode.GetListTypeRef(CodeHelper.TypeRef(node.Identifier)));
                        }

                        throw new NotImplementedException();
                    }
                    else
                    {
                        return CodeHelper.VarRef(node.Identifier);
                    }

            }
        }

        private CodeExpression GenerateImperativeExpression(CallExpression node)
        {
            if (node.FunctionExpression.Type != AphidExpressionType.IdentifierExpression &&
                node.FunctionExpression.Type != AphidExpressionType.BinaryOperatorExpression &&
                ((BinaryOperatorExpression)node.FunctionExpression).Operator != AphidTokenType.MemberOperator)
            {
                throw new NotImplementedException();
            }

            string id;
            ReferenceType funcType;

            if (node.FunctionExpression.Type == AphidExpressionType.IdentifierExpression)
            {
                id = ((IdentifierExpression)node.FunctionExpression).Identifier;
                funcType = ResolveType(id);
            }
            else
            {
                var ids = Flatten(node.FunctionExpression)
                    .Cast<IdentifierExpression>()
                    .Select(x => x.Identifier);

                id = string.Join(".", ids);
                funcType = ReferenceType.ExternalFunction;
            }

            var args = node.Args.Select(x => GenerateImperativeExpression(x)).ToArray();

            switch (funcType)
            {
                case ReferenceType.RuleClass:
                    return new CodeObjectCreateExpression(
                        id,
                        args
                            .Prepend(CodeHelper.FieldRef(ParserName.ContextField))
                            .ToArray());

                case ReferenceType.RuleDeclaration:
                    return CodeHelper.Invoke(id, args);

                case ReferenceType.ExternalFunction:
                    return CodeHelper.Invoke(id, args);

                default:
                    throw new NotImplementedException();
            }
        }

        private CodeExpression GenerateImperativeExpression(UnaryOperatorExpression node, bool isCondition = false)
        {
            if (!node.IsPostfix)
            {
                switch (node.Operator)
                {
                    case AphidTokenType.NotOperator:
                        var exp = GenerateImperativeExpression(node.Operand, isCondition);

                        return CodeHelper.BinOpExp(
                            exp,
                            CodeBinaryOperatorType.ValueEquality,
                            CodeHelper.False());

                    default:
                        throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private CodeExpression GenerateImperativeExpression(BinaryOperatorExpression node, bool isCondition = false)
        {
            var opTable = new Dictionary<AphidTokenType, CodeBinaryOperatorType>
            {
                { AphidTokenType.AdditionOperator, CodeBinaryOperatorType.Add },
                { AphidTokenType.MinusOperator, CodeBinaryOperatorType.Subtract },
                { AphidTokenType.MultiplicationOperator, CodeBinaryOperatorType.Multiply },
                { AphidTokenType.DivisionOperator, CodeBinaryOperatorType.Divide },
                { AphidTokenType.OrOperator, CodeBinaryOperatorType.BooleanOr },
                { AphidTokenType.AndOperator, CodeBinaryOperatorType.BooleanAnd },
                { AphidTokenType.BinaryOrOperator, CodeBinaryOperatorType.BooleanOr },
                { AphidTokenType.BinaryAndOperator, CodeBinaryOperatorType.BooleanAnd },
                { AphidTokenType.EqualityOperator, CodeBinaryOperatorType.ValueEquality },
                { AphidTokenType.NotEqualOperator, CodeBinaryOperatorType.IdentityInequality },
                { AphidTokenType.LessThanOperator, CodeBinaryOperatorType.LessThan },
                { AphidTokenType.GreaterThanOperator, CodeBinaryOperatorType.GreaterThan },
                { AphidTokenType.LessThanOrEqualOperator, CodeBinaryOperatorType.LessThanOrEqual },
                { AphidTokenType.GreaterThanOrEqualOperator, CodeBinaryOperatorType.GreaterThanOrEqual },
            };

            switch (node.Operator)
            {
                case AphidTokenType.MemberOperator:
                    if (node.RightOperand.Type != AphidExpressionType.IdentifierExpression)
                    {
                        throw new NotImplementedException();
                    }

                    return CodeHelper.PropRef(
                        GenerateImperativeExpression(node.LeftOperand),
                        ((IdentifierExpression)node.RightOperand).Identifier);

                default:
                    return CodeHelper.BinOpExp(
                        GenerateImperativeExpression(node.LeftOperand, isCondition),
                        opTable[node.Operator],
                        GenerateImperativeExpression(node.RightOperand, isCondition));
            }
        }

        private CodeExpression GenerateImperativeExpression(ArrayAccessExpression node)
        {
            return new CodeArrayIndexerExpression(
                GenerateImperativeExpression(node.ArrayExpression),
                node.KeyExpressions.Select(x => GenerateImperativeExpression(x)).ToArray());
        }

        private static CodeExpression GenerateImperativeExpression(NumberExpression node) =>
            new CodePrimitiveExpression((int)node.Value);

        private static CodePropertyReferenceExpression GetCurrentTokenType() =>
            GetCurrentTokenProp(ParserGeneratorDirective.CurrentTokenType);

        private static CodePropertyReferenceExpression GetCurrentLexeme() =>
            GetCurrentTokenProp(ParserGeneratorDirective.CurrentLexeme);

        private static CodePropertyReferenceExpression GetCurrentTokenProp(string propertyName) =>
            CodeHelper.PropRef("_currentToken", propertyName);

        private CodeFieldReferenceExpression GetTokenTypeRef(string tokenName) =>
            CodeHelper.FieldRef(CodeHelper.TypeRefExp(_config.TokenType), tokenName);

        private static CodeStatement GetNextTokenStatement() =>
            CodeHelper.Stmt(CodeHelper.Invoke("NextToken"));
    }
}
