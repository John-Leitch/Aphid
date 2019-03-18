using Components.Aphid.Interpreter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.TypeSystem
{
    public class ValueHelper : AphidRuntimeComponent
    {
        private readonly Dictionary<Type, string> _typeName = new Dictionary<Type, string>
        {
            { typeof(string), "string" },
            { typeof(decimal), "number" },
            { typeof(bool), "boolean" },
            { typeof(List<AphidObject>), "list" },
            { typeof(AphidObject), "object" },
            { typeof(AphidFunction), "function" }
        };

        public ValueHelper(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public static object Unwrap(AphidObject obj)
        {
            if (obj?.IsScalar == true)
            {
                return obj.Value;
            }

            return obj;
        }

        public static object Unwrap(object obj)
        {
            if (obj is AphidObject aphidObj && aphidObj.IsScalar)
            {
                return aphidObj.Value;
            }

            return obj;
        }

        //public static AphidObject Wrap(AphidObject obj) => obj ?? AphidObject.InternedNull;

        public static AphidObject Wrap(object obj)
        {
            if (obj is AphidObject aphidObj)
            {
                return aphidObj;
            }

            return AphidObject.Scalar(obj);
        }

        public static object DeepUnwrap(object obj)
        {
            if (obj is List<AphidObject> list)
            {
                return list.Select(DeepUnwrap).ToArray();
            }

            if (!(obj is AphidObject aphidObj))
            {
                return obj;
            }
            else if ((list = aphidObj.Value as List<AphidObject>) != null)
            {
                return list.Select(DeepUnwrap).ToArray();
            }
            else
            {
                return aphidObj.IsScalar ? aphidObj.Value : aphidObj;
            }
        }

        public object WrapNonNull(object obj)
        {
            var unwrapped = Unwrap(obj);

            if (unwrapped == null)
            {
                throw Interpreter.CreateRuntimeException(
                    "Expression evaluated to null, value expected.");
            }

            return unwrapped;
        }

        public IEnumerable<object> UnwrapIEnumerableObject(object obj) =>
            UnwrapIEnumerable(obj).Cast<object>();

        public IEnumerable UnwrapIEnumerable(object obj)
        {
            var unwrapped = Unwrap(obj);

            if (unwrapped is IEnumerable noFighting)
            {
                return noFighting;
            }

            if (unwrapped == null)
            {
                if (obj == null)
                {
                    throw Interpreter.CreateRuntimeException(
                        "Expression evaluated to null, IEnumerable expected.");
                }

                throw Interpreter.CreateRuntimeException(
                    "Expression evaluated to {0}, IEnumerable expected.",
                    obj.GetType());
            }

            throw Interpreter.CreateRuntimeException(
                "Expression evaluated to {0}, IEnumerable expected.",
                unwrapped.GetType());
        }

        public void AssertString(object value, string operation) =>
            AssertValue<string>(value, operation);

        public void AssertNumber(object value, string operation) =>
            AssertValue<decimal>(value, operation);

        public void AssertBool(object value, string operation) =>
            AssertValue<bool>(value, operation);

        public void AssertList(object value, string operation) =>
            AssertValue<List<AphidObject>>(value, operation);

        public void AssertObject(object value, string operation) =>
            AssertValue<AphidObject>(value, operation);

        public void AssertFunction(object value, string operation) =>
            AssertValue<AphidFunction>(value, operation);

        public void AssertValue<TExpected>(object value, string operation)
        {
            if (!(value is TExpected))
            {
                throw Interpreter.CreateRuntimeException(
                    "{0} expects {1}, {2} was provided instead.",
                    operation,
                    GetTypeName<TExpected>(),
                    GetTypeName(value));
            }
        }

        public string GetTypeName(Type type) => _typeName[type];

        public string GetTypeName<T>() => _typeName[typeof(T)];

        public string GetTypeName(object value) =>
            value != null ? _typeName[value.GetType()] : "null";

        public static AphidObject[] WrapObjectArray(object[] srcArray)
        {
            var dstArray = new AphidObject[srcArray.Length];

            for (var i = 0; i < dstArray.Length; i++)
            {
                dstArray[i] = Wrap(srcArray[i]);
            }

            return dstArray;
        }

        public static object[] WrapObjectArrayRef(object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = Wrap(array[i]);
            }

            return array;
        }

        public static object[] UnwrapObjectArray(object[] srcArray)
        {
            var dstArray = new object[srcArray.Length];

            for (var i = 0; i < dstArray.Length; i++)
            {
                dstArray[i] = Unwrap(srcArray[i]);
            }

            return dstArray;
        }

        public static object[] UnwrapObjectArrayRef(object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = Unwrap(array[i]);
            }

            return array;
        }

        public static object[] DeepUnwrapObjectArrayRef(object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = DeepUnwrap(array[i]);
            }

            return array;
        }
    }
}
