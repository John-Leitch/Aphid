using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Library
{
    [AphidLibrary("reflection")]
    public class ReflectionLibrary
    {
        [AphidInteropFunction("reflection.members", UnwrapParameters = false)]
        public static List<AphidObject> Members(AphidObject obj)
        {
            return obj.Select(x => new AphidObject(x.Key)).ToList();
        }
    }
}
