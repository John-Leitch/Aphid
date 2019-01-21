using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Runtime.Serialization;

namespace Components.ObjectDatabase
{
    [Serializable]
    public class IndexPredicateEvaluator
    {
        [NonSerialized]
        private AphidInterpreter _interpreter;

        [NonSerialized]
        private AphidObject _object;

        [NonSerialized]
        private AphidExpression _predicateExpression;

        private string _predicate;

        [DataMember]
        public string Predicate
        {
            get => _predicate;
            set
            {
                _predicate = value;
                _predicateExpression = null;
            }
        }

        public bool Execute(object entity)
        {
            if (_predicateExpression == null)
            {
                _predicateExpression = AphidParser.ParseExpression(_predicate);
                _object = AphidObject.Scalar(entity);
                _interpreter = new AphidInterpreter();
                _interpreter.CurrentScope.Add(AphidName.ImplicitArg, _object);
            }
            else
            {
                _object.Value = entity;
            }

            var resultObj = _interpreter.Interpret(_predicateExpression);
            var result = (bool)((AphidObject)resultObj).Value;

            return result;
        }
    }
}
