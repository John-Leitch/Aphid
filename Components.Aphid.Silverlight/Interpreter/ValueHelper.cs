using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public static class ValueHelper
    {
        private static Dictionary<Type, string> _typeName = new Dictionary<Type, string>
        {
            { typeof(string), "string" },
            { typeof(decimal), "number" },
            { typeof(bool), "boolean" },
            { typeof(List<AphidObject>), "list" },
            { typeof(AphidObject), "object" },
            { typeof(AphidFunction), "function" },
        };

        public static object Unwrap(object obj)
        {
            AphidObject aphidObj;

            return (aphidObj = obj as AphidObject) != null ? aphidObj.Value : obj;
        }

        public static AphidObject Wrap(object obj)
        {
            AphidObject aphidObj;

            return (aphidObj = obj as AphidObject) != null ? aphidObj : new AphidObject(obj);
        }

        public static object DeepUnwrap(object obj)
        {
            AphidObject aphidObj;
            List<AphidObject> list;

            if ((aphidObj = obj as AphidObject) == null)
            {
                return obj;
            }
            else if ((list = aphidObj.Value as List<AphidObject>) != null)
            {
                return list.Select(DeepUnwrap).ToArray();
            }
            else
            {
                return aphidObj.Value;
            }
        }

        public static void AssertString(object value, string operation)
        {
            AssertValue<string>(value, operation);
        }

        public static void AssertNumber(object value, string operation)
        {
            AssertValue<decimal>(value, operation);
        }

        public static void AssertBool(object value, string operation)
        {
            AssertValue<bool>(value, operation);
        }

        public static void AssertList(object value, string operation)
        {
            AssertValue<List<AphidObject>>(value, operation);
        }

        public static void AssertObject(object value, string operation)
        {
            AssertValue<AphidObject>(value, operation);
        }

        public static void AssertFunction(object value, string operation)
        {
            AssertValue<AphidFunction>(value, operation);
        }

        public static void AssertValue<TExpected>(object value, string operation)
        {
            if (!(value is TExpected))
            {
                throw new AphidRuntimeException(
                    "{0} expects {1}, {2} was provided instead.",
                    operation,
                    ValueHelper.GetTypeName<TExpected>(),
                    ValueHelper.GetTypeName(value));
            }
        }  

        public static string GetTypeName(Type type)
        {
            return _typeName[type];
        }

        public static string GetTypeName<T>()
        {
            return _typeName[typeof(T)];
        }

        public static string GetTypeName(object value)
        {
            return value != null ? _typeName[value.GetType()] : "null";
        }
    }

    public static class ValueHelper<TExpected>
    {
        
    }
}
