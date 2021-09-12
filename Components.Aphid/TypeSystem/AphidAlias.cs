using System;

namespace Components.Aphid.TypeSystem
{
    public static class AphidAlias
    {
        public static string Resolve(Type type) => Resolve(type.Name);

        public static string Resolve(string name)
        {
            return name switch
            {
                "List`1" or AphidType.List => AphidType.List,
                "Decimal" or AphidType.Number => AphidType.Number,
                "String" or AphidType.String => AphidType.String,
                "Boolean" or AphidType.Boolean => AphidType.Boolean,
                "AphidObject" or AphidType.Object => AphidType.Object,
                "AphidFunction" or AphidType.Function => AphidType.Function,
                "AphidInteropFunction" or AphidType.InteropFunction => AphidType.InteropFunction,
                "AphidInteropPartialFunction" or AphidType.PartialFunction => AphidType.PartialFunction,
                "AphidFunctionComposition" or AphidType.FunctionComposition => AphidType.FunctionComposition,
                AphidType.Unknown => AphidType.Unknown,
                _ => null,
            };
        }
    }
}
