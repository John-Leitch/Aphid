using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public static class TypeExtender
    {
        public static string GetName(string type, string nameStr)
        {
            return string.Format("$ext.{0}.{1}", type, nameStr);
        }

        public static void Extend(AphidInterpreter interpreter, string type, AphidObject extensions)
        {
            foreach (var extension in extensions)
            {
                var nameStr = extension.Key;
                var key = GetName(type, nameStr);

                if (interpreter.CurrentScope.ContainsKey(key))
                {
                    interpreter.CurrentScope[key] = extension.Value;                    
                }
                else
                {
                    interpreter.CurrentScope.Add(key, extension.Value);
                }
            }
        }

        public static AphidObject TryResolve(AphidObject scope, AphidObject obj, string key)
        {
            var t = obj.GetValueType();
            var extKey = TypeExtender.GetName(t, key);
            AphidObject val;

            if (!scope.TryResolve(extKey, out val))
            {
                return null;
            }

            var function = ((AphidFunction)val.Value).Clone();
            function.ParentScope = new AphidObject { Parent = scope };
            function.ParentScope.Add(function.Args[0], obj);
            function.Args = function.Args.Skip(1).ToArray();
            
            return new AphidObject(function);
        }
    }
}
