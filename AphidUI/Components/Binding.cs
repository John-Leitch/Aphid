using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using static Components.Aphid.Lexer.AphidTokenType;
using Exp = Components.Aphid.Parser.AphidExpressionType;
using Components.Aphid.TypeSystem;
using System;
using static Components.Aphid.Wpf.ExpressionHelper;
using DataBinding = System.Windows.Data.Binding;
using Components.External;

namespace Components.Aphid.Wpf
{
    [ContentProperty("Script")]
    public partial class Binding : System.Windows.Data.MultiBinding
    {
        private static Memoizer<string, AphidBindingContext> _memoizer = new Memoizer<string, AphidBindingContext>();

        private AphidBindingContext _context;

        public string Expression
        {
            get => Converter != null ? ((Aphid)Converter).Expression : null;
            set => SetExtension(value);
        }

        private string _script;

        [ConstructorArgument("script")]
        public string Script { get => _script; set => SetScriptConverter(value); }

        public string Path { get; set; }

        public Binding() { }

        public Binding(string script) => SetScriptConverter(script);

        private static AphidBindingContext DetectAndSetBindingPaths(string script) =>
            _memoizer.Call(DetectAndSetBindingPathsCore, script);

        private static AphidBindingContext DetectAndSetBindingPathsCore(string script)
        {
            var interpreter = Aphid.Interpreter ?? new AphidInterpreter();
            var ast = new List<AphidExpression> { AphidAttributeParser.Parse(script) };
            var expFinder = new ExpressionFinder();

            AphidExpressionType? ancestorType;
            AphidExpression ancestor;

            var results = expFinder.Find(
                ast,
                x =>
                    (x.Type == Exp.IdentifierExpression &&
                        ((ancestorType = (ancestor = expFinder.Ancestors.Skip(1).FirstOrDefault())?.Type) == null ||
                            ancestorType != Exp.FunctionExpression &&
                            (ancestorType != Exp.BinaryOperatorExpression ||
                            ancestor.ToBinaryOperator().Operator != MemberOperator))) ||
                    (x.Type == Exp.BinaryOperatorExpression &&
                        x.ToBinaryOperator().Operator == MemberOperator &&
                        x.ToBinaryOperator().LeftOperand.Type == Exp.IdentifierExpression),
                true)
                .Select(x => x.Type == Exp.BinaryOperatorExpression ? x.ToBinaryOperator().LeftOperand : x)
                .ToList();

            //x => expFinder.Ancestors.Skip(1).FirstOrDefault()?.Type != Exp.CallExpression && IsMemberPath(x),

            interpreter.EnterScope();
            AphidObject retVal;

            try
            {
                interpreter.Interpret(
                    new UnaryOperatorExpression(
                        retKeyword,
                        new ArrayExpression(results
                            .Select(x =>
                            {
                                var tryCatch = AphidParser.ParseExpression(@"
                                @{
                                    try {
                                        ret null;
                                    } catch {
                                        ret null;
                                    }
                                }()");


                                tryCatch
                                    .ToCall()
                                    .FunctionExpression
                                    .ToFunction()
                                    .Body[0]
                                    .ToTry()
                                    .TryBody[0]
                                    .ToUnaryOperator()
                                    .Operand = x;

                                return tryCatch;
                            })
                            .ToList())));

                

                //interpreter.Interpret(
                //    new UnaryOperatorExpression(
                //        retKeyword,
                //        new ArrayExpression(results
                //            .Select(x =>
                //                new UnaryOperatorExpression(definedKeyword, x, isPostfix:true))
                //            .ToList<AphidExpression>())));

                retVal = interpreter.GetReturnValue();
            }
            finally
            {
                interpreter.LeaveScope(bubbleReturnValue: false);
            }

            var defs = retVal
                .GetList()                
                //.Select(x => x.GetBool())
                .Select(x => x.IsComplex || x.Value != null)                
                .ToArray();

            var expressions = results.Where((x, i) => !defs[i]).ToArray();
            var expressionTable = expressions.GroupToArrayDictionary(GetMemberPath);
            var bindingPaths = expressionTable.Keys.ToArray();

            var start = 'x';

            var mutatedAst = new AphidBindingScriptMutator(
                expressionTable.WithKey(x => new IdentifierExpression((start++).ToString())))
                .Mutate(ast);
            
            return new AphidBindingContext(expressions, mutatedAst, bindingPaths);
        }

        private void SetExtension(string expression)
        {
            Converter = new Aphid() { AssociatedBinding = this, Expression = expression };            
            ConverterParameter = expression;
        }

        private void SetPath(string path) => AddPathBinding(path);

        private void SetScriptConverter(string script)
        {
            _script = script;
            _context = DetectAndSetBindingPaths(script);
            var node = _context.MutatedAst.Single();
            Converter = new Aphid(node) { AssociatedBinding = this };
            ConverterParameter = node;

            foreach (var b in _context.BindingPaths)
            {
                AddPathBinding(b);
            }
        }

        private void AddPathBinding(string path)
        {
            var b = new DataBinding(path)
            {
                Mode = Mode,
                ValidatesOnExceptions = ValidatesOnExceptions,
                UpdateSourceExceptionFilter = UpdateSourceExceptionFilter,
                ValidatesOnDataErrors = ValidatesOnDataErrors,
                NotifyOnValidationError = NotifyOnValidationError,
                NotifyOnSourceUpdated = NotifyOnSourceUpdated,
                UpdateSourceTrigger = UpdateSourceTrigger,
                NotifyOnTargetUpdated = NotifyOnTargetUpdated,
                ValidatesOnNotifyDataErrors = ValidatesOnNotifyDataErrors,
                FallbackValue = FallbackValue,
                StringFormat = StringFormat,
                TargetNullValue = TargetNullValue,
                BindingGroupName = BindingGroupName,
                Delay = Delay,
            };

            foreach (var v in ValidationRules)
            {
                b.ValidationRules.Add(v);
            }

            Bindings.Add(b);
        }
    }
}


