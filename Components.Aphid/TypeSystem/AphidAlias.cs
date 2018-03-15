using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public static class AphidAlias
    {
        public static string Resolve(Type type)
        {
            return Resolve(type.Name);
        }

        public static string Resolve(string name)
        {
            switch (name)
            {
                case "List`1":
                case AphidType.List:
                    return AphidType.List;

                case "Decimal":
                case AphidType.Number:
                    return AphidType.Number;

                case "String":
                case AphidType.String:
                    return AphidType.String;

                case "Boolean":
                case AphidType.Boolean:
                    return AphidType.Boolean;

                case "AphidObject":
                case AphidType.Object:
                    return AphidType.Object;

                case "AphidFunction":
                case AphidType.Function:
                    return AphidType.Function;

                case "AphidInteropFunction":
                case AphidType.InteropFunction:
                    return AphidType.InteropFunction;

                case "AphidInteropPartialFunction":
                case AphidType.PartialFunction:
                    return AphidType.PartialFunction;

                case "AphidFunctionComposition":
                case AphidType.FunctionComposition:
                    return AphidType.FunctionComposition;

                case AphidType.Unknown:
                    return AphidType.Unknown;

                default:
                    return null;
            }
        }
    }
}
