#define CHECK_ANCESTORS
using Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public abstract class AphidMutator
    {
        protected Stack<AphidExpression> Ancestors { get; private set; }

        public bool HasMutated { get; private set; }

        protected bool IsStatement { get; private set; }

        public bool HasFinalized { get; private set; }

        public AphidMutator()
        {
            Ancestors = new Stack<AphidExpression>();
        }

        protected abstract List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged);

        protected virtual List<AphidExpression> OnMutate(List<AphidExpression> ast)
        {
            return ast;
        }

        protected virtual void BeginRecursiveMutationPass(List<AphidExpression> ast) { }

        protected virtual void EndRecursiveMutationPass(List<AphidExpression> ast) { }

        public List<AphidExpression> Mutate(List<AphidExpression> ast)
        {
#if CHECK_ANCESTORS
            CheckAncestorStack();
#endif

            var mutatedAst = MutateInternal(ast);

#if CHECK_ANCESTORS
            CheckAncestorStack();
#endif

            return mutatedAst;
        }

        private List<AphidExpression> MutateInternal(List<AphidExpression> ast)
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
                ast2.AddRange(MutateExpression(exp));
            }

            return ast2;
        }

        private AphidExpression MutateSingle(AphidExpression expression)
        {
            var result = MutateExpression(expression);

            if (result.Count != 1)
            {
                var msg = result.Count > 0 ?
                    string.Format(
                        "Expression {0} expanded into multiple expressions {1} by " +
                        "{2}, one expected.",
                        expression,
                        result.Select(x => x.Type.ToString()).Join(", "),
                        GetType()) :
                    string.Format(
                        "Expression {0} expanded into null by {1}.",
                        expression,
                        GetType());

                throw new AphidParserException(msg, expression);
            }

            return result[0];
        }

        private List<AphidExpression> MutateExpression(AphidExpression expression)
        {
            if (HasFinalized)
            {
                return new List<AphidExpression> { expression };
            }

            Ancestors.Push(expression);
            var code = expression.Code;
            bool hasChanged;
            var mutated = MutateCore(expression, out hasChanged);            

            if (hasChanged)
            {
                HasMutated = true;
                var recursivelyMutated = new List<AphidExpression>(mutated.Count);

                for (var i = 0; i < mutated.Count; i++)
                {
                    recursivelyMutated.AddRange(
                        MutateExpression(
                            mutated[i].WithPositionFrom(expression)));
                }

                Ancestors.Pop();
                
                return recursivelyMutated;
            }

            IsStatement = false;
            var expanded = new List<AphidExpression>();

            switch (expression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var id = (IdentifierExpression)expression;

                    expanded.Add(
                        new IdentifierExpression(
                            id.Identifier,
                            id.Attributes
                                .Select(x => (IdentifierExpression)MutateSingle(x))
                                .ToList())
                            .WithPositionFrom(id));
                    break;

                case AphidExpressionType.CallExpression:
                    var call = (CallExpression)expression;

                    expanded.Add(
                        new CallExpression(
                            MutateSingle(call.FunctionExpression),
                            call.Args.Select(x => MutateSingle(x)).ToList())
                            .WithPositionFrom(call));

                    break;

                case AphidExpressionType.UnaryOperatorExpression:
                    var unOp = (UnaryOperatorExpression)expression;

                    expanded.Add(
                        new UnaryOperatorExpression(
                            unOp.Operator,
                            MutateSingle(unOp.Operand), 
                            unOp.IsPostfix)
                            .WithPositionFrom(unOp));

                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    var binOp = (BinaryOperatorExpression)expression;

                    expanded.Add(
                        new BinaryOperatorExpression(
                            MutateSingle(binOp.LeftOperand),
                            binOp.Operator,
                            MutateSingle(binOp.RightOperand))
                            .WithPositionFrom(binOp));

                    break;

                case AphidExpressionType.BinaryOperatorBodyExpression:
                    var binOpBody = (BinaryOperatorBodyExpression)expression;
                    
                    expanded.Add(
                        new BinaryOperatorBodyExpression(
                            binOpBody.Operator,
                            (FunctionExpression)MutateSingle(binOpBody.Function))
                            .WithPositionFrom(binOpBody));

                    //binOpBody.function

                    break;

                case AphidExpressionType.SwitchExpression:
                    var switchExp = (SwitchExpression)expression;

                    expanded.Add(
                        new SwitchExpression(
                            MutateSingle(switchExp.Expression),
                            switchExp.Cases
                                .Select(x =>
                                    (SwitchCase)new SwitchCase(
                                        x.Cases.Select(MutateSingle).ToList(),
                                        MutateInternal(x.Body))
                                        .WithPositionFrom(x))
                                .ToList(),
                            MutateInternal(switchExp.DefaultCase))
                            .WithPositionFrom(switchExp));

                    break;

                case AphidExpressionType.IfExpression:
                    var ifExp = (IfExpression)expression;

                    expanded.Add(
                        new IfExpression(
                            MutateSingle(ifExp.Condition),
                            MutateInternal(ifExp.Body),
                            MutateInternal(ifExp.ElseBody))
                            .WithPositionFrom(ifExp));

                    break;

                case AphidExpressionType.ForExpression:
                    var forExp = (ForExpression)expression;

                    expanded.Add(
                        new ForExpression(
                            MutateSingle(forExp.Initialization),
                            MutateSingle(forExp.Condition),
                            MutateSingle(forExp.Afterthought),
                            MutateInternal(forExp.Body))
                            .WithPositionFrom(forExp));

                    break;

                case AphidExpressionType.ForEachExpression:
                    var forEachExp = (ForEachExpression)expression;

                    expanded.Add(
                        new ForEachExpression(
                            MutateSingle(forEachExp.Collection),
                            MutateInternal(forEachExp.Body),
                            forEachExp.Element != null ?
                                MutateSingle(forEachExp.Element) :
                                null)
                            .WithPositionFrom(forEachExp));

                    break;

                case AphidExpressionType.WhileExpression:
                    var cfExp = (WhileExpression)expression;
                    
                    expanded.Add(
                        new WhileExpression(
                            MutateSingle(cfExp.Condition),
                            MutateInternal(cfExp.Body))
                            .WithPositionFrom(cfExp));

                    break;

                case AphidExpressionType.DoWhileExpression:
                    var dwExp = (DoWhileExpression)expression;
                    
                    expanded.Add(
                        new DoWhileExpression(
                            MutateSingle(dwExp.Condition),
                            MutateInternal(dwExp.Body))
                            .WithPositionFrom(dwExp));

                    break;

                case AphidExpressionType.LoadScriptExpression:
                    var lsExp = (LoadScriptExpression)expression;
                    
                    expanded.Add(
                        new LoadScriptExpression(MutateSingle(lsExp.FileExpression))
                            .WithPositionFrom(lsExp));

                    break;

                case AphidExpressionType.LoadLibraryExpression:
                    var llExp = (LoadLibraryExpression)expression;
                    
                    expanded.Add(
                        new LoadLibraryExpression(MutateSingle(llExp.LibraryExpression))
                            .WithPositionFrom(llExp));

                    break;

                case AphidExpressionType.FunctionExpression:
                    var funcExp = (FunctionExpression)expression;

                    expanded.Add(
                        new FunctionExpression(
                            funcExp.Args.Select(x => MutateSingle(x)).ToList(),
                            MutateInternal(funcExp.Body))
                            .WithPositionFrom(funcExp));

                    break;

                case AphidExpressionType.ArrayExpression:
                    var arrayExp = (ArrayExpression)expression;

                    expanded.Add(
                        new ArrayExpression(
                            arrayExp.Elements.Select(x => MutateSingle(x)).ToList())
                            .WithPositionFrom(arrayExp));

                    break;

                case AphidExpressionType.ArrayAccessExpression:
                    var arrayAccessExp = (ArrayAccessExpression)expression;

                    expanded.Add(
                        new ArrayAccessExpression(
                            MutateSingle(arrayAccessExp.ArrayExpression),
                            arrayAccessExp.KeyExpressions.Select(x => MutateSingle(x)).ToList())
                            .WithPositionFrom(arrayAccessExp));

                    break;

                case AphidExpressionType.ObjectExpression:
                    var obj = ((ObjectExpression)expression);

                    var pairs = obj.Pairs
                        .Select(x => (BinaryOperatorExpression)MutateSingle(x))
                        .ToList();

                    var objId = obj.Identifier != null ?
                        (IdentifierExpression)MutateSingle(obj.Identifier) :
                        null;

                    expanded.Add(
                        new ObjectExpression(pairs, objId)
                            .WithPositionFrom(obj));
                    break;

                case AphidExpressionType.ExtendExpression:
                    var extendExp = (ExtendExpression)expression;

                    expanded.Add(
                        new ExtendExpression(
                            (IdentifierExpression)MutateSingle(extendExp.ExtendType),
                            (ObjectExpression)MutateSingle(extendExp.Object))
                            .WithPositionFrom(extendExp));

                    break;

                case AphidExpressionType.TernaryOperatorExpression:
                    var terExp = (TernaryOperatorExpression)expression;

                    expanded.Add(
                        new TernaryOperatorExpression(
                            terExp.Operator,
                            MutateSingle(terExp.FirstOperand),
                            MutateSingle(terExp.SecondOperand),
                            MutateSingle(terExp.ThirdOperand))
                            .WithPositionFrom(terExp));

                    break;

                case AphidExpressionType.DynamicMemberExpression:
                    var dynExp = (DynamicMemberExpression)expression;

                    expanded.Add(
                        new DynamicMemberExpression(
                            MutateSingle(dynExp.MemberExpression))
                            .WithPositionFrom(dynExp));

                    break;

                case AphidExpressionType.PartialFunctionExpression:
                    var pfExp = (PartialFunctionExpression)expression;

                    expanded.Add(
                        new PartialFunctionExpression(MutateSingle(pfExp.Call))
                            .WithPositionFrom(pfExp));

                    break;

                case AphidExpressionType.GatorEmitExpression:
                    var emit = (GatorEmitExpression)expression;

                    expanded.Add(
                        new GatorEmitExpression(MutateSingle(emit.Expression))
                            .WithPositionFrom(emit));

                    break;

                case AphidExpressionType.TryExpression:
                    var tryExp = (TryExpression)expression;

                    expanded.Add(
                        new TryExpression(
                            MutateInternal(tryExp.TryBody),
                            tryExp.CatchArg != null ?
                                (IdentifierExpression)MutateSingle(tryExp.CatchArg) :
                                null,
                            MutateInternal(tryExp.CatchBody),
                            MutateInternal(tryExp.FinallyBody))
                            .WithPositionFrom(tryExp));

                    break;

                case AphidExpressionType.PatternMatchingExpression:
                    var patternMatchingExp = (PatternMatchingExpression)expression;

                    expanded.Add(
                        new PatternMatchingExpression(
                            MutateSingle(patternMatchingExp.TestExpression),
                            patternMatchingExp.Patterns
                                .Select(x => (PatternExpression)MutateSingle(x))
                                .ToList())
                            .WithPositionFrom(patternMatchingExp));
                    
                    break;

                case AphidExpressionType.PatternExpression:
                    var patternExp = (PatternExpression)expression;

                    expanded.Add(
                        new PatternExpression(
                            MutateSingle(patternExp.Value),
                            patternExp.Patterns.Select(x => MutateSingle(x)).ToList())
                            .WithPositionFrom(patternExp));

                    break;

                case AphidExpressionType.PartialOperatorExpression:
                    var partialOp = (PartialOperatorExpression)expression;

                    expanded.Add(
                        new PartialOperatorExpression(
                            partialOp.Operator,
                            MutateSingle(partialOp.Operand))
                            .WithPositionFrom(partialOp));

                    break;

                case AphidExpressionType.UsingExpression:
                    var usingExp = (UsingExpression)expression;

                    expanded.Add(
                        new UsingExpression(
                            MutateSingle(usingExp.Disposable),
                            usingExp.Body.SelectMany(MutateExpression).ToList())
                            .WithPositionFrom(usingExp));

                    break;

                case AphidExpressionType.LockExpression:
                    var lockExp = (LockExpression)expression;

                    expanded.Add(
                        new LockExpression(
                            lockExp.Expressions.SelectMany(MutateExpression).ToList(),
                            lockExp.Body.SelectMany(MutateExpression).ToList())
                            .WithPositionFrom(lockExp));

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

            Ancestors.Pop();

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
                ast = MutateInternal(ast);
                EndRecursiveMutationPass(ast);
                if (HasMutated)
                {
                    anyMutations = true;
                }
            } while (HasMutated && !HasFinalized);

            HasMutated = anyMutations;

            return ast;
        }

        public virtual void Reset()
        {
            HasMutated = false;
        }

#if CHECK_ANCESTORS
        private void CheckAncestorStack()
        {
            if (Ancestors.Any())
            {
                throw new InvalidOperationException("Mutator Ancestor stack unbalanced.");
            }
        }
#endif

        protected void FinalizeMutation()
        {
            HasFinalized = true;
        }
    }
}
