using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Debugging
{
        [DebuggerDisplay("{_value,nq}", Name = "{_key}")]
        internal class AphidMember
        {
            private readonly AphidObject _aphidObject;
            private readonly string _key;
            private readonly AphidObject _value;

            public AphidMember(AphidObject aphidObject, string key, AphidObject value)
            {
                _aphidObject = aphidObject;
                _key = key;
                _value = value;
            }
        }
}
