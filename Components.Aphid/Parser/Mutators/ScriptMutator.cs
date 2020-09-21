﻿using Components.External;
using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Parser
{
    public class ScriptMutator : AphidMutator
    {
        private readonly Lazy<List<AphidExpression>> _mutateImplementation;

        private readonly string _script;

        private readonly AphidObject _parentScope;

        public AphidInterpreter Interpreter { get; set; }

        public ScriptMutator() =>
            _mutateImplementation =
                new Lazy<List<AphidExpression>>(() => AphidParser.Parse(_script));

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
                mutateImplementation.Body) => _parentScope = mutateImplementation.ParentScope;

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            Interpreter.EnterSharedScope(_parentScope ?? Interpreter.CurrentScope);

            try
            {
                var s = Interpreter.CurrentScope;
                s.Add("ancestors", AphidObject.Scalar(Ancestors));
                s.Add("isStatement", AphidObject.Scalar(IsStatement));
                s.Add("expression", AphidObject.Scalar(expression));
                s.Add("hasChanged", AphidObject.InternedFalse);

                s.Add(
                    "finalize",
                    AphidObject.Scalar(new AphidInteropFunction((interpreter, args) =>
                    {
                        FinalizeMutation();

                        return null;
                    })));

                Interpreter.Interpret(_mutateImplementation.Value);
                List<AphidExpression> mutated = null;

                if (Interpreter.CurrentScope.TryResolve("hasChanged", out var hasChangedObj) &&
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

                    var t = retVal.Value.GetType();

                    mutated = t == typeof(List<AphidExpression>)
                        ? (List<AphidExpression>)retVal.Value
                        : t == typeof(AphidFunction)
                            ? ((AphidFunction)retVal.Value).Body
                            : t.IsDerivedFrom<AphidExpression>()
                                                    ? new List<AphidExpression> { (AphidExpression)retVal.Value }
                                                    : throw Interpreter.CreateRuntimeException(
                                                                            "Mutator returned invalid type, expected expression, block, or function.");
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
