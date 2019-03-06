using System.Diagnostics;
using System.Linq;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Debugging
{
    [DebuggerDisplay("{Details}")]
    internal class AphidObjectDebugView
    {
        private readonly AphidObject _aphidObject;

        public string Details => ToString();

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public AphidMember[] Members =>
            _aphidObject
                .Select(x => new AphidMember(_aphidObject, x.Key, x.Value))
            .ToArray();

        public AphidObjectDebugView(AphidObject aphidObject) =>
            _aphidObject = aphidObject;

        public override string ToString() =>
            _aphidObject.IsComplex ?
                $"Object (Count = {_aphidObject.Count})" :
            _aphidObject.Value != null ?
                $"Scalar {_aphidObject.Value.GetType().Name} = {_aphidObject.Value}" :
                "Scalar null";
    }
}
