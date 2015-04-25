using AphidCodeGenerator;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class ParserGenerator
    {
        private const string
            _nodeLocal = "node",
            _tokenAttribute = "token",
            _baseAttribute = "base",
            _nodeAttribute = "node",
            _namespaceAttribute = "namespace",
            _parserAttribute = "parser",
            _currentTokenType = "TokenType",
            _currentLexeme = "Lexeme",
            _nextTokenFunc = "NextToken",
            _matchFunc = "Match";

        private string
            //_tokenType = "TokenType", 
            _baseType = "Node",
            _parsePrefix = "Parse";

        private Dictionary<string, string> _locals = new Dictionary<string, string>();

        private string[] _ruleNames;

        private RuleTypeTable _ruleTypes = new RuleTypeTable();

        private string _currenType;

        private ParserGeneratorConfig _config;

        private AphidObject _scope = new AphidObject();

        private string[] _tokenTypes = Enum.GetNames(typeof(AphidTokenType));

        private void EnterChildScope()
        {
            _scope = new AphidObject() { Parent = _scope };
        }

        private void LeaveChildScope()
        {
            _scope = _scope.Parent;
        }

        private BinaryOperatorExpression[] GetRules(List<AphidExpression> nodes)
        {
            return nodes
                .Where(x => x.Type == AphidExpressionType.BinaryOperatorExpression)
                .Cast<BinaryOperatorExpression>()
                .Where(x =>
                    x.LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
                    x.RightOperand.Type == AphidExpressionType.FunctionExpression)
                .ToArray();
        }

        public string Generate(List<AphidExpression> nodes)
        {
            ParseDirectives(nodes);
            ParseRuleStructs(nodes);
            nodes = new PlusEqualMutator().MutateRecursively(nodes);
            var rules = GetRules(nodes);
            _ruleNames = GetRuleNames(nodes).ToArray();
            var mutator = new TypeInferenceMutator(_config);

            do
            {
                foreach (var r in rules)
                {
                    var func = r.RightOperand.ToFunction();
                    func.Body = mutator.MutateRecursively(func.Body);
                }
            }
            while (mutator.HasMutated);

            var declMutator = new DeclarativeStatementMutator(_tokenTypes, _ruleNames);
            nodes = declMutator.Mutate(nodes);

            //rules = GetRules(nodes);
            //var callIdMutator = new CallIdentifierMutator(_ruleNames);
            ////nodes = callIdMutator.Mutate(nodes);
            //foreach (var r in rules)
            //{
            //    var func = r.RightOperand.ToFunction();
            //    func.Body = callIdMutator.Mutate(func.Body);
            //}

            var typeClasses = CreateRuleTypeClasses();

            var enumBuilder = new EnumBuilder(_config.BaseClass, _ruleTypes.Select(x => x.Key));
            var enumDecl = enumBuilder.CreateEnum();
            
            var ns = new CodeNamespace(
                string.Join(".", _config.Namespace.Concat(new[] { "Parser" })));

            ns.Imports.Add(new System.CodeDom.CodeNamespaceImport(
                string.Join(".", _config.Namespace.Concat(new[] { "Lexer" }))));
            ns.Types.Add(enumDecl);
            //ns.Types.AddRange(typeClasses);

            var parserType = new CodeTypeDeclaration(_config.ParserClass)
            {
                IsPartial = true,
            };

            parserType.Members.AddRange(nodes.Select(Generate).Where(x => x != null).ToArray());
            ns.Types.Add(parserType);

            var str = CSharpHelper.GenerateCode(ns);

            return str;
        }

        private void ParseDirectives(List<AphidExpression> nodes)
        {
            _config = new ParserGeneratorConfig(
                ParseDirective(nodes, _tokenAttribute),
                ParseDirective(nodes, _baseAttribute),
                ParseDirective(nodes, _nodeAttribute),
                ParseDirectiveArray(nodes, _namespaceAttribute),
                ParseDirective(nodes, _parserAttribute));
        }

        private string ParseDirective(List<AphidExpression> nodes, string directive)
        {
            var exp = nodes
                .OfType<IdentifierExpression>()
                .SingleOrDefault(x => x.Attributes.Count == 1 && x.Attributes.First().Identifier == directive);

            nodes.Remove(exp);

            return exp != null ? exp.Identifier : null;
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
                    ((IdentifierExpression)x.Values.First()).Attributes.Count == 1 &&
                    ((IdentifierExpression)x.Values.First()).Attributes.First().Identifier == directive);

            if (idSeq == null)
            {
                return new string[0];
            }

            nodes.Remove(idSeq.Expression);

            return idSeq.Values
                .Cast<IdentifierExpression>()
                .Select(x => x.Identifier)
                .ToArray();
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
                    x.Name.Attributes.Any() ? x.Name.Attributes.Single().Identifier : _config.BaseClass,
                    x.Properties))
                .ToArray();

            foreach (var t in types)
            {
                _ruleTypes.Add(t);
            }
        }

        public CodeTypeDeclarationCollection CreateRuleTypeClasses()
        {
            return new CodeTypeDeclarationCollection(
                _ruleTypes
                    .Select(x => x.Value)
                    .Select(CreateCodeType)
                    .ToArray());
        }

        public CodeTypeDeclaration CreateCodeType(RuleStruct rule)
        {
            // Todo: extract code helper methods from this bullshit
            var decl = new CodeTypeDeclaration(rule.Name)
            {
                IsPartial = true,
            };

            decl.BaseTypes.Add(CodeHelper.TypeRef(rule.BaseName));

            var properties = CreateProperties(rule);

            foreach (var p in properties)
            {
                p.GetStatements.Add(CodeHelper.Return(GetFieldName(p.Name)));
            }

            decl.Members.AddRange(properties);

            decl.Members.AddRange(
                properties
                    .Select(x => new CodeMemberField(x.Type, GetFieldName(x.Name))
                    {
                        Attributes = MemberAttributes.Private,
                    })
                    .ToArray());

            var ctor = new CodeConstructor()
            {
                Attributes = MemberAttributes.Public,
            };

            ctor.Parameters.AddRange(
                properties
                    .Select(x => CreateCtorParameter(rule, x))
                    .ToArray());

            ctor.Statements.AddRange(
                properties
                    .Select(x => CodeHelper.Assign(GetFieldName(x.Name), GetLocalName(x.Name)))
                    .ToArray());

            decl.Members.Add(ctor);

            return decl;
        }

        private CodeParameterDeclarationExpression CreateCtorParameter(RuleStruct rule, CodeMemberProperty property)
        {
            var exp = new CodeParameterDeclarationExpression(
                property.Type,
                GetLocalName(property.Name));

            if (rule.Properties.Single(x => x.Name == property.Name).IsOptional)
            {
                exp.CustomAttributes.Add(new CodeAttributeDeclaration(CodeHelper.TypeRef<OptionalAttribute>()));
            }

            return exp;
        }

        private CodeMemberProperty[] CreateProperties(RuleStruct ruleType)
        {
            return ruleType.Properties
                .Select(x => new CodeMemberProperty()
                {
                    Name = x.Name,
                    Attributes = MemberAttributes.Public | MemberAttributes.Final,
                    Type = GetTypeRef(x),
                    HasGet = true,
                })
                .ToArray();
        }

        private string GetFieldName(string name)
        {
            return "_" + GetLocalName(name);
        }

        private string GetLocalName(string name)
        {
            return name.Substring(0, 1).ToLower() + name.Substring(1);
        }

        private CodeTypeReference GetListTypeRef(CodeTypeReference typeArg)
        {
            var listTypeRef = CodeHelper.TypeRef(typeof(List<>));
            listTypeRef.TypeArguments.Add(typeArg);

            return listTypeRef;
        }

        private CodeTypeReference GetTypeRef(ParserIdentifier property)
        {
            CodeTypeReference typeRef;

            switch (property.Type)
            {
                case "bool":
                    typeRef = CodeHelper.TypeRef<bool>();
                    break;

                case "string":
                    typeRef = CodeHelper.TypeRef<string>();
                    break;

                default:
                    typeRef = CodeHelper.TypeRef(property.Type);
                    break;
            }

            if (property.IsList)
            {
                return GetListTypeRef(typeRef);
            }

            return typeRef;
        }

        private CodeMethodInvokeExpression GetNextToken()
        {
            return CodeHelper.Invoke("NextToken");
        }

        private string[] GetRuleNames(List<AphidExpression> nodes)
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

            if (!func.Body.Any())
            {
                return null;
                //return new CodeStatementCollection();
                body = new CodeStatement[0];
            }
            else
            {
                body = func.Body
                    .SelectMany(x => GenerateImperativeStatement(x).OfType<CodeStatement>())
                    .ToArray();
            }

            var methodAttrs = ParseMethodAttributes(funcId);
            var typeRef = CodeHelper.TypeRef(methodAttrs.Type);

            var method = new System.CodeDom.CodeMemberMethod()
            {
                Name = funcId.Identifier,
                ReturnType = methodAttrs.IsList ? GetListTypeRef(typeRef) : typeRef,
            };

            if (methodAttrs.IsRoot)
            {
                method.Attributes = MemberAttributes.Public | MemberAttributes.Final;
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
                typeRef = parserId.IsList ? GetListTypeRef(typeRef) : typeRef;
                var init = new CodeDefaultValueExpression(typeRef);
                var varDecl = new CodeVariableDeclarationStatement(typeRef, node.Identifier, init);
                _scope.Add(node.Identifier, new AphidObject());

                return new CodeStatementCollection(new[] { varDecl });
            }
            else
            {
                return new CodeStatementCollection(new[]
                {
                    new CodeThrowExceptionStatement(
                        new CodeObjectCreateExpression(
                            _config.ExceptionClass,
                            CodeHelper.VarRef("_currentToken")))
                });
            }
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
                        case _nextTokenFunc:
                            return new CodeStatementCollection(new[] { GetNextTokenStatement() });

                        case _matchFunc:
                            return new CodeStatementCollection(new[]
                            {
                                CodeHelper.Stmt(
                                    CodeHelper.Invoke(
                                        _matchFunc, 
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

                    if (funcExp is CodePropertyReferenceExpression)
                    {
                        var prop = (CodePropertyReferenceExpression)funcExp;
                        var parameters = node.Args.Select(x => GenerateImperativeExpression(x, false)).ToArray();

                        return new CodeStatementCollection(new[]
                        {
                            CodeHelper.Stmt(CodeHelper.Invoke(
                                prop.TargetObject, 
                                prop.PropertyName,
                                parameters))
                        });
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
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
                AphidObject obj;
                if (!_scope.TryResolve(id, out obj))
                {
                    _scope.Add(id, new AphidObject());

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
                new CodeStatement[0];

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

            if (node.DefaultCase != null && node.DefaultCase.Any())
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

        private CodeStatementCollection GenerateImperativeStatement(BreakExpression node)
        {
            return new CodeStatementCollection(new[] { new CodeSnippetStatement("break;") });
        }

        private CodeStatementCollection GenerateImperativeStatements(List<AphidExpression> nodes)
        {
            EnterChildScope();

            var stmts = nodes
                .SelectMany(x => GenerateImperativeStatement(x).OfType<CodeStatement>())
                .ToArray();

            LeaveChildScope();

            return new CodeStatementCollection(stmts);
        }

        private bool IsTokenType(string name)
        {
            return _tokenTypes.Contains(name);
        }

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

                default:
                    throw new NotImplementedException();

            }
        }

        private CodeExpression GenerateImperativeExpression(BooleanExpression node)
        {
            return node.Value ? CodeHelper.True() : CodeHelper.False();
        }

        private CodeExpression GenerateImperativeExpression(IdentifierExpression node, bool isCondition = false)
        {
            switch (node.Identifier)
            {
                case _currentTokenType:
                    return GetCurrentTokenType();

                case _currentLexeme:
                    return GetCurrentLexeme();

                default:
                    if (IsTokenType(node.Identifier))
                    {
                        var exp = (CodeExpression)GetTokenTypeRef(node.Identifier);

                        if (!isCondition)
                        {
                            return exp;
                        }
                        else
                        {
                            return CodeHelper.BinOpExp(
                                GetCurrentTokenType(),
                                CodeBinaryOperatorType.ValueEquality,
                                exp);
                        }
                    }
                    else if (node.Attributes.Any())
                    {
                        var attr = node.Attributes.Single().Identifier;

                        if (attr == "list")
                        {
                            return new CodeObjectCreateExpression(
                                GetListTypeRef(CodeHelper.TypeRef(node.Identifier)));
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
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
                    return new CodeObjectCreateExpression(id, args);

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
                { AphidTokenType.OrOperator, CodeBinaryOperatorType.BooleanOr },
                { AphidTokenType.AndOperator, CodeBinaryOperatorType.BooleanAnd },
                { AphidTokenType.BinaryOrOperator, CodeBinaryOperatorType.BooleanOr },
                { AphidTokenType.BinaryAndOperator, CodeBinaryOperatorType.BooleanAnd },
                { AphidTokenType.EqualityOperator, CodeBinaryOperatorType.ValueEquality },
                { AphidTokenType.NotEqualOperator, CodeBinaryOperatorType.IdentityInequality },
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
                GenerateImperativeExpression(node.KeyExpression));
        }

        private CodeExpression GenerateImperativeExpression(NumberExpression node)
        {
            return new CodePrimitiveExpression((int)node.Value);
        }

        private CodePropertyReferenceExpression GetCurrentTokenType()
        {
            return GetCurrentTokenProp(_currentTokenType);
        }

        private CodePropertyReferenceExpression GetCurrentLexeme()
        {
            return GetCurrentTokenProp(_currentLexeme);
        }

        private CodePropertyReferenceExpression GetCurrentTokenProp(string propertyName)
        {
            return CodeHelper.PropRef("_currentToken", propertyName);
        }

        private CodeFieldReferenceExpression GetTokenTypeRef(string tokenName)
        {
            return CodeHelper.FieldRef(CodeHelper.TypeRefExp(_config.TokenType), tokenName);
        }

        private CodeStatement GetNextTokenStatement()
        {
            return CodeHelper.Stmt(CodeHelper.Invoke("NextToken"));
        }
    }
}
