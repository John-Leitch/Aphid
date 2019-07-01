using System;
using System.Collections.Generic;
using System.Linq;
using Components.Aphid.Interpreter;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.UI.Formatters
{
    public static class SerializingFormatter
    {
        public static string Format(
            AphidInterpreter interpreter,
            object value,
            bool ignoreNull = true,
            bool ignoreClrObj = true,
            List<AphidObject> scopes = null) =>
            Format(interpreter, false, value, ignoreNull, ignoreClrObj,  scopes);

        public static string Format(
            AphidInterpreter interpreter,
            bool serializeRootScope,
            object value,
            bool ignoreNull = true,
            bool ignoreClrObj = true,
            List<AphidObject> scopes = null)
        {
            string result;

            try
            {
                var obj = ValueHelper.Wrap(value);

                if (scopes != null)
                {
                    var scopeIndex = scopes.IndexOf(obj);

                    if (scopeIndex >= (serializeRootScope ? 1 : 0))
                    {
                        var ops = Enumerable.Repeat(".{'$parent'}", scopeIndex).Join();

                        return $"this{ops}";
                    }
                }

                result = CreateSerializer(interpreter).Serialize(obj);
            }
            catch (Exception e)
            {
                var ex = ExceptionHelper.Flatten(e).Select(x => x.Message).JoinLines();

                return $"Error dumping {value.GetType()}: {ex}";
            }

            return
                (ignoreClrObj && result.StartsWith("clrObject(")) ||
                (ignoreNull && result == "null") ? "" :
                result;
        }

        public static AphidSerializer CreateSerializer(AphidInterpreter interpreter) =>
            interpreter.CurrentScope.TryResolve(AphidName.DumpSerializer, out var dumpSerializerObj) &&
            dumpSerializerObj != null &&
            dumpSerializerObj.IsScalar &&
            dumpSerializerObj.Value is AphidSerializer dumpSerializer ? dumpSerializer :
            new AphidSerializer(interpreter)
            {
                IgnoreFunctions = true,
                IgnoreLazyLists = false,
                IgnoreSpecialVariables = true,
                QuoteToStringResults = false,
                ToStringClrTypes = false,
                MaxElements = AphidConfig.Current.StackTraceParamsMax
            };
    }
}
