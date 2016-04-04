using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public abstract class AphidMutator
    {
        public bool HasMutated { get; private set; }

        protected bool IsStatement { get; private set; }

        protected abstract List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged);

        protected virtual List<AphidExpression> OnMutate(List<AphidExpression> ast)
        {
            return ast;
        }

        protected virtual void BeginRecursiveMutationPass(List<AphidExpression> ast) { }

        protected virtual void EndRecursiveMutationPass(List<AphidExpression> ast) { }

        private AphidExpression MutateSingle(AphidExpression expression)
        {
            return Mutate(expression).Single();
        }

        public List<AphidExpression> Mutate(List<AphidExpression> ast)
        {
            if (ast == null)
            {
                return null;
            }

            ast = OnMutate(ast);

            var ast2 = new List<AphidExpression>();

            foreach (var exp in ast)
            {
                IsStatement = true;
                ast2.AddRange(Mutate(exp));
            }

            return ast2;
        }

        private List<AphidExpression> Mutate(AphidExpression expression)
        {
            bool hasChanged;
            var mutated = MutateCore(expression, out hasChanged);            

            if (hasChanged)
            {
                HasMutated = true;
                return mutated.SelectMany(Mutate).ToList();
            }

            IsStatement = false;
            var expanded = new List<AphidExpression>();

            switch (expression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var id = (IdentifierExpression)expression;

                    expanded.Add(new IdentifierExpression(
                        id.Identifier,
                        id.Attributes
                            .Select(x => (IdentifierExpression)Mutate(x).Single())
                            .ToList()));
                    break;

                case AphidExpressionType.CallExpression:
                    var call = (CallExpression)expression;

                    expanded.Add(new CallExpression(
                        Mutate(call.FunctionExpression).Single(),
                        call.Args.Select(x => Mutate(x).Single()).ToList()));

                    break;

                case AphidExpressionType.UnaryOperatorExpression:
                    var unOp = (UnaryOperatorExpression)expression;

                    expanded.Add(new UnaryOperatorExpression(
                        unOp.Operator,
                        Mutate(unOp.Operand).Single(), 
                        unOp.IsPostfix));

                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    var binOp = (BinaryOperatorExpression)expression;

                    expanded.Add(new BinaryOperatorExpression(
                        Mutate(binOp.LeftOperand).Single(),
                        binOp.Operator,
                        Mutate(binOp.RightOperand).Single()));

                    break;

                case AphidExpressionType.SwitchExpression:
                    var switchExp = (SwitchExpression)expression;

                    expanded.Add(new SwitchExpression(
                        MutateSingle(switchExp.Expression),
                        switchExp.Cases
                            .Select(x => new SwitchCase(
                                x.Cases.Select(MutateSingle).ToList(),
                                Mutate(x.Body)))
                            .ToList(),
                        Mutate(switchExp.DefaultCase)));

                    break;

                case AphidExpressionType.IfExpression:
                    var ifExp = (IfExpression)expression;

                    expanded.Add(new IfExpression(
                        Mutate(ifExp.Condition).Single(),
                        Mutate(ifExp.Body),
                        Mutate(ifExp.ElseBody)));

                    break;

                case AphidExpressionType.ForExpression:
                    var forExp = (ForExpression)expression;

                    expanded.Add(new ForExpression(
                        Mutate(forExp.Initialization).Single(),
                        Mutate(forExp.Condition).Single(),
                        Mutate(forExp.Afterthought).Single(),
                        Mutate(forExp.Body)));

                    break;

                case AphidExpressionType.ForEachExpression:
                    var forEachExp = (ForEachExpression)expression;

                    expanded.Add(
                        new ForEachExpression(
                            Mutate(forEachExp.Collection).Single(),
                            Mutate(forEachExp.Element).Single(),
                            Mutate(forEachExp.Body)));

                    break;

                case AphidExpressionType.WhileExpression:
                    var cfExp = (WhileExpression)expression;
                    expanded.Add(new WhileExpression(Mutate(cfExp.Condition).Single(), Mutate(cfExp.Body)));
                    break;

                case AphidExpressionType.DoWhileExpression:
                    var dwExp = (DoWhileExpression)expression;
                    expanded.Add(new DoWhileExpression(Mutate(dwExp.Condition).Single(), Mutate(dwExp.Body)));
                    break;

                case AphidExpressionType.LoadScriptExpression:
                    var lsExp = (LoadScriptExpression)expression;
                    expanded.Add(new LoadScriptExpression(Mutate(lsExp.FileExpression).Single()));
                    break;

                case AphidExpressionType.LoadLibraryExpression:
                    var llExp = (LoadLibraryExpression)expression;
                    expanded.Add(new LoadLibraryExpression(Mutate(llExp.LibraryExpression).Single()));
                    break;

                case AphidExpressionType.FunctionExpression:
                    var funcExp = (FunctionExpression)expression;

                    expanded.Add(new FunctionExpression(
                        funcExp.Args.Select(x => Mutate(x).Single()).ToList(),
                        Mutate(funcExp.Body)));

                    break;

                case AphidExpressionType.ArrayExpression:
                    var arrayExp = (ArrayExpression)expression;

                    expanded.Add(new ArrayExpression(
                        arrayExp.Elements.Select(x => Mutate(x).Single()).ToList()));

                    break;

                case AphidExpressionType.ArrayAccessExpression:
                    var arrayAccessExp = (ArrayAccessExpression)expression;

                    expanded.Add(new ArrayAccessExpression(
                        Mutate(arrayAccessExp.ArrayExpression).Single(),
                        Mutate(arrayAccessExp.KeyExpression).Single()));

                    break;

                case AphidExpressionType.ObjectExpression:
                    var obj = ((ObjectExpression)expression);

                    var pairs = obj.Pairs
                        .Select(x => (BinaryOperatorExpression)Mutate(x).Single())
                        .ToList();

                    var objId = obj.Identifier != null ? 
                        (IdentifierExpression)Mutate(obj.Identifier).Single() :
                        null;

                    expanded.Add(new ObjectExpression(pairs, objId));
                    break;

                case AphidExpressionType.ExtendExpression:
                    var extendExp = (ExtendExpression)expression;

                    expanded.Add(new ExtendExpression(
                        extendExp.ExtendType,
                        (ObjectExpression)Mutate(extendExp.Object).Single()));

                    break;

                case AphidExpressionType.TernaryOperatorExpression:
                    var terExp = (TernaryOperatorExpression)expression;

                    expanded.Add(
                        new TernaryOperatorExpression(
                            terExp.Operator,
                            Mutate(terExp.FirstOperand).Single(),
                            Mutate(terExp.SecondOperand).Single(),
                            Mutate(terExp.ThirdOperand).Single()));

                    break;

                case AphidExpressionType.DynamicMemberExpression:
                    var dynExp = (DynamicMemberExpression)expression;

                    expanded.Add(
                        new DynamicMemberExpression(
                            Mutate(dynExp.MemberExpression).Single()));

                    break;

                case AphidExpressionType.PartialFunctionExpression:
                    var pfExp = (PartialFunctionExpression)expression;

                    expanded.Add(
                        new PartialFunctionExpression(Mutate(pfExp.Call).Single()));

                    break;

                case AphidExpressionType.GatorEmitExpression:
                    var emit = (GatorEmitExpression)expression;

                    expanded.Add(
                        new GatorEmitExpression(Mutate(emit.Expression).Single()));

                    break;

                case AphidExpressionType.TryExpression:
                    var tryExp = (TryExpression)expression;

                    expanded.Add(
                        new TryExpression(
                            Mutate(tryExp.TryBody),
                            tryExp.CatchArg != null ? 
                                (IdentifierExpression)Mutate(tryExp.CatchArg).Single() :
                                null,
                            Mutate(tryExp.CatchBody),
                            Mutate(tryExp.FinallyBody)));

                    break;

                case AphidExpressionType.PatternMatchingExpression:
                    var patternMatchingExp = (PatternMatchingExpression)expression;

                    expanded.Add(
                        new PatternMatchingExpression(
                            Mutate(patternMatchingExp.TestExpression).Single(),
                            patternMatchingExp.Patterns
                                .Select(x => (PatternExpression)Mutate(x).Single())
                                .ToList()));
                    
                    break;

                case AphidExpressionType.PatternExpression:
                    var patternExp = (PatternExpression)expression;

                    expanded.Add(
                        new PatternExpression(
                            Mutate(patternExp.Value).Single(),
                            patternExp.Patterns.Select(x => Mutate(x).Single()).ToList()));

                    break;

                case AphidExpressionType.PartialOperatorExpression:
                    var partialOp = (PartialOperatorExpression)expression;

                    expanded.Add(
                        new PartialOperatorExpression(
                            partialOp.Operator,
                            Mutate(partialOp.Operand).Single()));

                    break;

                default:
                    if (expression is IParentNode)
                    {
                        throw new NotImplementedException();
                    }
                    else
                    {
                        expanded.Add(expression);
                    }

                    break;
            }

            return expanded;
        }

        public List<AphidExpression> MutateRecursively(List<AphidExpression> expression)
        {
            List<AphidExpression> ast = expression;

            var anyMutations = false;

            do
            {
                Reset();
                BeginRecursiveMutationPass(ast);
                ast = Mutate(ast);
                EndRecursiveMutationPass(ast);
                if (HasMutated)
                {
                    anyMutations = true;
                }
            } while (HasMutated);

            HasMutated = anyMutations;

            return ast;
        }

        public virtual void Reset()
        {
            HasMutated = false;
        }
    }
}
