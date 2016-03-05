using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coywolf
{




    public class AphidPhpEmitter : AphidStringEmitter
    {
        private readonly string[] _builtInFunctions = File.ReadAllLines("phpFunctions.txt");

        private Dictionary<AphidTokenType, string> _unaryPrefixOperators = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.retKeyword, "return " },
        };

        private int _varNumber = 0;

        private bool _isPhp = false;

        private const string _header = @"<?php
function __add($lhs, $rhs) {
	return gettype($lhs) == 'string' || gettype($rhs) == 'string' ?
		$lhs . $rhs :
		$lhs + $rhs;
}
?>";
        private bool IsBuildInFunction(string id)
        {
            return _builtInFunctions.Contains(id);
        }

        public override string Compile(List<AphidExpression> ast)
        {
            var mutators = new AphidMutator[] 
            {
                new IncludeMutator(),
                new AphidMacroMutator(),
                new PipelineToCallMutator(),
            };

            foreach (var mutator in mutators)
            {
                
                ast = mutator.MutateRecursively(ast);
            }

            return base.Compile(ast);
        }

        protected override void EmitHeader()
        {
            Append(_header.Replace("{", "{{").Replace("}", "}}"));

            base.EmitHeader();
        }

        protected override void BeginStatement(AphidExpression expression)
        {
            Append(GetTabs());
            base.BeginStatement(expression);
        }

        protected override void BeginExpression(AphidExpression expression)
        {
            if (_isPhp && expression.Type == AphidExpressionType.TextExpression)
            {
                Append("?>");
                _isPhp = false;
            }
            else if (expression.Type == AphidExpressionType.GatorEmitExpression)
            {
                _isPhp = true;
            }
            else if (!_isPhp &&
                expression.Type != AphidExpressionType.TextExpression &&
                expression.Type != AphidExpressionType.GatorEmitExpression)
            {
                Append("<?php\r\n");
                _isPhp = true;
            }

            base.BeginExpression(expression);
        }

        protected override void EndExpression(AphidExpression expression)
        {
            if (expression.Type == AphidExpressionType.GatorEmitExpression)
            {
                _isPhp = false;
            }

            base.EndExpression(expression);
        }

        public override void Emit(List<AphidExpression> statements)
        {
            base.Emit(statements);

            if (!_isPhp)
            {
                _isPhp = true;
                Append("<?php ");
            }
        }

        protected override void Emit(AphidExpression expression, bool isStatement = false)
        {
            base.Emit(expression, isStatement);

            if (isStatement &&
                expression.Type != AphidExpressionType.TextExpression &&
                expression.Type != AphidExpressionType.GatorEmitExpression &&
                expression.Type != AphidExpressionType.IfExpression &&
                expression.Type != AphidExpressionType.ForEachExpression)
            {
                Append(";\r\n");
            }
        }

        protected override void EmitTextExpression(TextExpression expression, bool isStatement = false)
        {
            Append(expression.Text);
        }

        protected override void EmitGatorEmitExpression(GatorEmitExpression expression, bool isStatement = false)
        {
            Append("<?= ");
            Append("htmlentities(");
            Emit(expression.Expression);
            Append(", ENT_QUOTES)");
            Append(" ?>");
        }

        protected override void EmitIdentifierExpression(IdentifierExpression expression, bool isStatement = false)
        {
            if (expression.Attributes.Any())
            {
                throw new NotImplementedException();
            }

            Append(
                "{0}{1}",
                !IsBuildInFunction(expression.Identifier) ? "$" : "",
                expression.Identifier);
        }

        protected override void EmitUnaryOperatorExpression(UnaryOperatorExpression expression, bool isStatement = false)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.retKeyword:
                    Append("return ");
                    Emit(expression.Operand);
                    break;

                default:
                    base.EmitUnaryOperatorExpression(expression, isStatement);
                    break;
            }


        }

        protected override void EmitBinaryOperatorExpression(BinaryOperatorExpression expression, bool isStatement = false)
        {
            if (expression.Operator != AphidTokenType.AdditionOperator)
            {
                base.EmitBinaryOperatorExpression(expression, isStatement);
            }
            else
            {
                Append("__add(");
                Emit(expression.LeftOperand);
                Append(", ");
                Emit(expression.RightOperand);
                Append(")");
            }
        }

        protected override void EmitStringExpression(StringExpression expression, bool isStatement = false)
        {
            base.EmitStringExpression(expression, isStatement);
        }

        protected override void EmitFunctionExpression(FunctionExpression expression, bool isStatement = false)
        {
            Append("function (");
            EmitTuple(expression.Args);
            Append(") {\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append(GetTabs() + "}");
        }

        public class PhpUseIdFinder : ExpressionFinder
        {
            public List<AphidExpression> Find(List<AphidExpression> source)
            {
                return Find(source, AphidExpressionType.IdentifierExpression);
            }

            protected override IEnumerable<AphidExpression> GetChildren(IParentNode parent)
            {
                var callExp = parent as CallExpression;

                if (callExp == null)
                {
                    return base.GetChildren(parent);
                }
                else
                {
                    return new List<AphidExpression> { callExp.FunctionExpression };
                }
            }
        }

        protected override void EmitPartialFunctionExpression(PartialFunctionExpression expression, bool isStatement = false)
        {
            var arg = NextId();
            Append("(function(${0}) ", arg);

            var used = new PhpUseIdFinder()
                .Find(expression.GetChildren().ToList())
                .Cast<IdentifierExpression>()
                .Where(x => !IsBuildInFunction(x.Identifier));

            if (used.Any())
            {
                Append("use (");
                EmitTuple(used);
                Append(") ");
            }

            Append("{ return ");

            var callArgs = expression.Call.Args
                .Concat(new[] { new IdentifierExpression(arg) })
                .ToList();

            Emit(new CallExpression(
                expression.Call.FunctionExpression,
                callArgs.ToList()));

            Append("; })");
        }

        protected override void EmitCallExpression(CallExpression expression, bool isStatement = false)
        {
            switch (expression.FunctionExpression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    switch (expression.FunctionExpression.ToIdentifier().Identifier)
                    {
                        case "echo":
                            EmitEchoStatement(expression);
                            return;
                    }

                    break;

                case AphidExpressionType.FunctionExpression:
                case AphidExpressionType.PartialFunctionExpression:
                    Append("call_user_func(\r\n");
                    Indent();
                    AppendTabs();
                    Emit(expression.FunctionExpression);
                    if (expression.Args.Any())
                    {
                        Append(",\r\n{0}", GetTabs());
                        EmitTuple(expression.Args);
                    }
                    Append(")");
                    return;
            }

            base.EmitCallExpression(expression, isStatement);
        }

        protected override void EmitForEachExpression(ForEachExpression expression, bool isStatement = false)
        {
            Append("foreach (");
            Emit(expression.Collection);
            Append(" as ");
            Emit(expression.Element);
            Append("){\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append(GetTabs() + "}\r\n");
        }

        protected override void EmitIfExpression(IfExpression expression, bool isStatement = false)
        {
            Append("if (");
            Emit(expression.Condition);
            Append(") {\r\n");
            Indent();
            Emit(expression.Body);
            Unindent();
            Append(GetTabs() + "}\r\n");
        }

        protected void EmitEchoStatement(CallExpression expression)
        {
            Append("echo ");
            EmitTuple(expression.Args);
        }

        private string NextId()
        {
            return string.Format("id_{0:X8}", _varNumber++);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var code = File.ReadAllText("test.alx");
            var ast = AphidParser.Parse(code, isTextDocument: true);
            var emitter = new AphidPhpEmitter();
            var str = emitter.Compile(ast);
            File.WriteAllText(@"c:\xampp\htdocs\test.php", str);
        }

//        private static string GenerateTokenMethods()
//        {
//            var fmt = "protected virtual void Visit{0}({0} expression) {{ }}";

//            var methods = Enum
//                .GetValues(typeof(AphidExpressionType))
//                .OfType<AphidExpressionType>()
//                .Select(x => new
//                {
//                    Token = x,
//                    Decl = string.Format(fmt, x.ToString())
//                })
//                .ToArray();

//            var methodDecls = methods
//                .Select(x => x.Decl)
//                .Aggregate((x, y) => x + "\r\n" + y);

//            var expCases = methods
//                .Select(x => string.Format(
//                    "case AphidExpressionType.{0}: Emit{0}(({0})expression); break;",
//                    x.Token))
//                .Aggregate((x, y) => x + "\r\n" + y);

//            var expSwitchFmt = @"
//                private void Emit(AphidExpression expression)
//                {{
//                    switch (expression.Type)
//                    {{
//                        {0}
//                        default:
//                            throw new NotImplementedException();
//                    }}
//                }}
//";
//            var expSwitch = string.Format(expSwitchFmt, expCases);

//            var code = expSwitch + "\r\n" + methodDecls;


//            return "";
//        }
    }
}
