using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Components.Aphid.TypeSystem
{
    [Serializable]
    public class AphidFunction : IEnumerable<AphidExpression>, IAphidCallable
    {
        [NonSerialized]
        private AphidObject _parentScope;

        //[ScriptIgnore, IgnoreDataMember]
        [IgnoreDataMember]
        public AphidObject ParentScope
        {
            get => _parentScope;
            set => _parentScope = value;
        }

        public string[] Args { get; set; }

        public List<AphidExpression> Body { get; set; }

        public AphidFunction()
            : this(Array.Empty<string>(), new List<AphidExpression>(), null)
        {
        }

        public AphidFunction(string[] args, List<AphidExpression> body, AphidObject parentScope)
        {
            Args = args;
            Body = body;
            ParentScope = parentScope;
        }

        public AphidFunction Clone() => new(Args, Body, ParentScope);

        public IEnumerator<AphidExpression> GetEnumerator() => Body != null ?
                Body.GetEnumerator() :
                ((IEnumerable<AphidExpression>)Array.Empty<AphidExpression>()).GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => Body != null ?
                ((System.Collections.IEnumerable)Body).GetEnumerator() :
                Array.Empty<AphidExpression>().GetEnumerator();
    }
}
