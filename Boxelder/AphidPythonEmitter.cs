using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Boxelder
{
    public class AphidPythonEmitter : AphidStringEmitter
    {
        private Dictionary<AphidTokenType, string> _unaryPrefixOperators = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.retKeyword, "return " },
            { AphidTokenType.NotOperator, "not " },
            { AphidTokenType.throwKeyword, "raise " },
        };

        private Dictionary<AphidTokenType, string> _binaryOperators = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.AndOperator, " and " },
            { AphidTokenType.OrOperator, " or " },
        };

        private const string _initName = "__init__";

        private uint _varId = 0;

        private bool _isEndingStatements;

        public override string Compile(string filename, List<AphidExpression> ast)
        {
            var mutators = new AphidMutator[]
            {
                new IncludeMutator
                {
                    PerformCommonTransformations = false,
                    DisableCaching = true
                },
                new AphidMacroMutator(),
                new PipelineToCallMutator(),
                new PartialOperatorMutator(),
                new UnaryExpressionMutator(),
                new LambdaPositionMutator(),
                new SwitchToIfMutator(),
            };

            foreach (var mutator in mutators)
            {
                ast = mutator.MutateRecursively(ast);
            }

            return base.Compile(filename, ast);
        }

        private void AppendStatement(string format, params object[] args)
        {
            Append(GetTabs() + format, args);
        }

        protected override void BeginStatement(AphidExpression expression)
        {
            Append(GetTabs());
            _isEndingStatements = false;
        }

        protected override void EndStatement(AphidExpression expression)
        {
            if (!_isEndingStatements)
            {
                AppendLine();
                _isEndingStatements = true;
            }
        }

        protected override void EmitHeader()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var border = new string('#', 64) + "\r\n";
            Append(
                "{0}# Compiled from Aphid to Python by Boxelder {1}\r\n# {2}\r\n{0}",
                border,
                version,
                "https://github.com/John-Leitch/Aphid/releases");
        }

        protected override void EmitNumberExpression(NumberExpression expression, bool isStatement = false)
        {
            Append(expression.Value);
        }

        protected override void EmitBooleanExpression(BooleanExpression expression, bool isStatement = false)
        {
            Append(expression.Value ? "True" : "False");
        }

        protected override void EmitIdentifierExpression(IdentifierExpression expression, bool isStatement = false)
        {
            if (!isStatement)
            {
                if (expression.Attributes.Count > 0)
                {
                    throw new NotImplementedException();
                }

                Append(expression.Identifier);
            }
            else
            {
                EmitIdentifierStatement(expression);
            }
        }

        protected override void EmitNullExpression(NullExpression expression, bool isStatement = false)
        {
            Append("None");
        }

        protected void EmitIdentifierStatement(IdentifierExpression expression)
        {
            var attrs = AphidAttributeParser.Parse<IdentifierStatementAttributes>(expression, out var unparsed);

            if (unparsed.Length > 0)
            {
                throw new NotImplementedException();
            }
            else if (attrs.IsThrow)
            {
                Append("raise {0}", expression.Identifier);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        protected override void EmitBinaryOperatorExpression(BinaryOperatorExpression expression, bool isStatement = false)
        {
            if (expression.RightOperand.Type != AphidExpressionType.FunctionExpression)
            {
                var useParens = !isStatement && expression.Operator != AphidTokenType.AssignmentOperator;

                if (useParens)
                {
                    Append("(");
                }

                Emit(expression.LeftOperand);
                Append(GetBinaryOperator(expression.Operator));
                Emit(expression.RightOperand);

                if (useParens)
                {
                    Append(")");
                }
            }
            else
            {
                EmitFunctionDeclarationStatement(expression, isMember: false);
            }
        }

        protected override void EmitTernaryOperatorExpression(TernaryOperatorExpression expression, bool isStatement = false)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.ConditionalOperator:
                    Append("((");
                    Emit(expression.SecondOperand);
                    Append(") if (");
                    Emit(expression.FirstOperand);
                    Append(") else (");
                    Emit(expression.ThirdOperand);
                    Append("))");
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        protected void EmitFunctionDeclarationStatement(BinaryOperatorExpression expression, bool isMember)
        {
            var id = expression.LeftOperand.ToIdentifier();
            var func = expression.RightOperand.ToFunction();
            var attrs = AphidAttributeParser.Parse<FunctionDeclarationAttributes>(id, out var unparsed);

            if ((!isMember && attrs.IsStatic) || unparsed.Length > 0)
            {
                throw new NotImplementedException();
            }

            if (attrs.IsStatic)
            {
                Append("@staticmethod\r\n");
                AppendTabs();
            }

            Append("def {0}(", id.Identifier);

            if (isMember && !attrs.IsStatic)
            {
                Append("self{0}", func.Args.Count > 0 ? ", " : "");
            }

            EmitTuple(func.Args);
            Append("):\r\n");
            Indent();
            Emit(func.Body);
            Unindent();
            AppendLine();
        }

        protected override void EmitPartialFunctionExpression(PartialFunctionExpression expression, bool isStatement = false)
        {
            var id = NextVarId();
            Append("(lambda {0}:", id);
            Emit(expression.Call.FunctionExpression);
            Append("(");
            EmitTuple(expression.Call.Args);
            Append(", {0}))", id);
        }

        protected override void EmitIfExpression(IfExpression expression, bool isStatement = false)
        {
            Append("if ");
            Emit(expression.Condition);
            Append(":\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();

            if (expression.ElseBody?.Count > 0)
            {
                AppendTabs();
                Append("else:\r\n");
                Indent();
                Emit(expression.ElseBody);
                Unindent();
            }
        }

        protected override void EmitForEachExpression(ForEachExpression expression, bool isStatement = false)
        {
            Append("for ");
            Emit(expression.Element);
            Append(" in ");
            Emit(expression.Collection);
            Append(":\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
        }

        protected override void EmitWhileExpression(WhileExpression expression, bool isStatement = false)
        {
            Append("while ");
            Emit(expression.Condition);
            Append(":\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
        }

        protected override void EmitBreakExpression(BreakExpression expression, bool isStatement = false)
        {
            Append("break");
        }

        protected override void EmitCallExpression(CallExpression expression, bool isStatement = false)
        {
            if (expression.FunctionExpression.Type == AphidExpressionType.IdentifierExpression)
            {
                var id = expression.FunctionExpression.ToIdentifier().Identifier;

                if (isStatement)
                {
                    switch (id)
                    {
                        case "import":
                            EmitImportStatement(expression);
                            return;

                        case "from":
                            EmitFromStatement(expression);
                            return;
                    }
                }

                switch (id)
                {
                    case "__emit":
                        EmitRaw(expression);
                        return;
                }
            }

            base.EmitCallExpression(expression, isStatement);
        }

        protected override void EmitObjectExpression(ObjectExpression expression, bool isStatement = false)
        {
            if (isStatement)
            {
                EmitObjectStatement(expression);
            }
            else
            {
                EmitDictionaryExpression(expression);
            }
        }

        protected void EmitDictionaryExpression(ObjectExpression expression)
        {
            if (expression.Identifier != null)
            {
                throw new NotImplementedException();
            }

            Append("{");
            var isFirst = true;

            foreach (var kvp in expression.Pairs)
            {
                if (!isFirst)
                {
                    Append(", ");
                }
                else
                {
                    isFirst = false;
                }

                var exp = new StringExpression(
                    string.Format("'{0}'", kvp.LeftOperand.ToIdentifier().Identifier));

                Emit(exp);
                Append(": ");
                Emit(kvp.RightOperand);
            }

            Append("}");
        }

        protected void EmitObjectStatement(ObjectExpression statement)
        {
            if (statement.Identifier == null)
            {
                throw new NotImplementedException();
            }

            var attrs = AphidAttributeParser.Parse<ClassDeclarationAttributes>(statement.Identifier, out var otherAttrs);

            if (attrs.IsClass)
            {
                EmitClassStatement(statement, attrs, otherAttrs);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        protected void EmitClassStatement(
            ObjectExpression statement,
            ClassDeclarationAttributes attributes,
            string[] unparsedAttributes)
        {
            if (unparsedAttributes.Length > 1)
            {
                throw new NotImplementedException();
            }

            if (attributes.IsIter)
            {
                statement.Pairs.Add(CreateIterExpression());
            }

            if (attributes.IsAutoInit)
            {
                UpdateInitExpression(statement);
            }

            Append(
                "class {0}({1}):",
                statement.Identifier.Identifier,
                unparsedAttributes.Length > 0 ? unparsedAttributes[0] : "");

            Indent();
            AppendLine();

            foreach (var p in statement.Pairs)
            {
                AppendTabs();

                if (p.RightOperand.Type != AphidExpressionType.FunctionExpression)
                {
                    Emit(p.LeftOperand);
                    Append(" = ");
                    Emit(p.RightOperand);
                    AppendLine();
                }
                else
                {
                    EmitFunctionDeclarationStatement(p, isMember: true);
                }
            }

            Unindent();
            AppendLine();
        }

        protected override void EmitTryExpression(TryExpression expression, bool isStatement = false)
        {
            Append("try:\r\n");
            EmitBlock(expression.TryBody);

            if (expression.CatchBody != null)
            {
                if (expression.CatchArg == null)
                {
                    AppendStatement("except:\r\n");
                }
                else
                {
                    var attrs = string.Join(
                        ", ",
                        expression.CatchArg.Attributes.Count > 0 ?
                        expression.CatchArg.Attributes
                            .Select(x => x.Identifier)
                            .ToArray() :
                        new[] { "BaseException" });

                    AppendStatement(
                        "except ({0}) as {1}:\r\n",
                        attrs,
                        expression.CatchArg.Identifier);
                }

                EmitBlock(expression.CatchBody);
            }

            if (expression.FinallyBody != null)
            {
                AppendStatement("finally:\r\n");
                EmitBlock(expression.FinallyBody);
            }
        }

        private bool HasAllStringArgs(CallExpression expression)
        {
            return expression.Args.All(x => x.Type == AphidExpressionType.StringExpression);
        }

        protected void EmitImportStatement(CallExpression statement)
        {
            if (statement.Args.Count == 0 || !HasAllStringArgs(statement))
            {
                throw new NotImplementedException();
            }

            Append("import ");
            // Injectable, should be fixed.
            var names = string.Join(", ", ParseStringArgs(statement));
            Append("{0}", names);
        }

        protected void EmitFromStatement(CallExpression statement)
        {
            if (statement.Args.Count < 2 || !HasAllStringArgs(statement))
            {
                throw new InvalidOperationException();
            }

            // Injectable, should be fixed.
            var strings = ParseStringArgs(statement);

            Append(
                "from {0} import {1}",
                strings.First(),
                string.Join(", ", strings.Skip(1)));
        }

        protected void EmitRaw(CallExpression statement)
        {
            if (statement.Args.Count != 1 || !HasAllStringArgs(statement))
            {
                throw new NotImplementedException();
            }

            Append(ParseStringArgs(statement).Single());
        }

        protected void EmitBlock(List<AphidExpression> block)
        {
            Indent();
            Emit(block);
            Unindent();
        }

        private IEnumerable<string> ParseStringArgs(CallExpression expression)
        {
            return expression.Args
                .Cast<StringExpression>()
                .Select(x => StringParser.Parse(x.Value));
        }

        protected override string GetBinaryOperator(AphidTokenType op)
        {

            return !_binaryOperators.TryGetValue(op, out var value) ?
                base.GetBinaryOperator(op) :
                value;
        }

        protected override string GetUnaryPrefixOperator(AphidTokenType op)
        {

            return !_unaryPrefixOperators.TryGetValue(op, out var value) ?
                base.GetUnaryPrefixOperator(op) :
                value;
        }

        private BinaryOperatorExpression CreateIterExpression()
        {
            return AphidParser
                .Parse("{__iter__:@()self};")
                .Cast<ObjectExpression>()
                .Single().Pairs
                .Single();
        }

        private void UpdateInitExpression(ObjectExpression classDeclaration)
        {
            var init = classDeclaration.Pairs
                .SingleOrDefault(x => x.LeftOperand.ToIdentifier().Identifier == _initName);

            if (init == null)
            {
                return;
            }

            if (init.RightOperand.Type != AphidExpressionType.FunctionExpression)
            {
                throw new NotImplementedException();
            }

            var func = init.RightOperand.ToFunction();

            var assigns = func.Args
                .Select(GetArgIdentifier)
                .Select(x => new BinaryOperatorExpression(
                    new BinaryOperatorExpression(
                        new IdentifierExpression("self"),
                        AphidTokenType.MemberOperator,
                        x),
                    AphidTokenType.AssignmentOperator,
                    x))
                .ToArray();

            func.Body.InsertRange(0, assigns);
        }

        private IdentifierExpression GetArgIdentifier(AphidExpression arg)
        {
            switch (arg.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    return (IdentifierExpression)arg;

                case AphidExpressionType.BinaryOperatorExpression:
                    var binOpExp = (BinaryOperatorExpression)arg;

                    if (binOpExp.LeftOperand.Type != AphidExpressionType.IdentifierExpression)
                    {
                        throw new NotImplementedException();
                    }

                    return binOpExp.LeftOperand.ToIdentifier();

                default:
                    throw new NotImplementedException();
            }
        }

        private string NextVarId()
        {
            return string.Format("var_{0:X8}", _varId++);
        }
    }
}
