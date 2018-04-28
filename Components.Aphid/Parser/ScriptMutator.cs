using Components.External;
using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Parser
{
    public class ScriptMutator : AphidMutator
    {
        private Lazy<List<AphidExpression>> _mutateImplementation;

        private string _script;

        private AphidObject _parentScope;

        public AphidInterpreter Interpreter { get; set; }

        public ScriptMutator()
        {
            _mutateImplementation = new Lazy<List<AphidExpression>>(() => AphidParser.Parse(_script));
        }

        public ScriptMutator(AphidInterpreter interpreter, string script)
            : this()
        {
            Interpreter = interpreter;
            _script = script;
        }

        public ScriptMutator(AphidInterpreter interpreter, List<AphidExpression> mutateImplementation)
        {
            Interpreter = interpreter;
            _mutateImplementation = new Lazy<List<AphidExpression>>(() => mutateImplementation);
        }

        public ScriptMutator(AphidFunction mutateImplementation)
            : this(
                (AphidInterpreter)mutateImplementation.ParentScope.Resolve(null, "$aphid").Value,
                mutateImplementation.Body)
        {
            _parentScope = mutateImplementation.ParentScope;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            Interpreter.EnterSharedScope(_parentScope ?? Interpreter.CurrentScope);

            try
            {
                var s = Interpreter.CurrentScope;
                s.Add("ancestors", AphidObject.Scalar(Ancestors));
                s.Add("isStatement", AphidObject.Scalar(IsStatement));
                s.Add("expression", AphidObject.Scalar(expression));
                s.Add("hasChanged", AphidObject.Scalar(false));

                s.Add(
                    "finalize",
                    AphidObject.Scalar(new AphidInteropFunction((interpreter, args) =>
                    {
                        FinalizeMutation();

                        return null;
                    })));

                Interpreter.Interpret(_mutateImplementation.Value);
                AphidObject hasChangedObj;
                List<AphidExpression> mutated = null;

                if (Interpreter.CurrentScope.TryResolve("hasChanged", out hasChangedObj) &&
                    hasChangedObj.GetValueType() == AphidType.Boolean &&
                    hasChangedObj.GetBool())
                {
                    hasChanged = true;
                    var retVal = Interpreter.GetReturnValue();

                    if (retVal == null || retVal.Value == null)
                    {
                        throw Interpreter.CreateRuntimeException(
                            "Mutator implementation returned null, expected expression(s).");
                    }
                    else
                    {
                        var t = retVal.Value.GetType();

                        if (t == typeof(List<AphidExpression>))
                        {
                            mutated = (List<AphidExpression>)retVal.Value;
                        }
                        else if (t == typeof(AphidFunction))
                        {
                            mutated = ((AphidFunction)retVal.Value).Body;
                        }
                        else if (t.IsDerivedFrom<AphidExpression>())
                        {
                            mutated = new List<AphidExpression> { (AphidExpression)retVal.Value };
                        }
                        else
                        {
                            throw Interpreter.CreateRuntimeException(
                                "Mutator returned invalid type, expected expression, block, or function.");
                        }
                    }
                }
                else
                {
                    hasChanged = false;
                    mutated = new List<AphidExpression> { expression };
                }

                return mutated;
            }
            finally
            {
                Interpreter.LeaveSharedScope();
            }
        }
    }
}
