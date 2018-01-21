using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class ValueHelper : AphidInterpreterComponent
    {
        private Dictionary<Type, string> _typeName = new Dictionary<Type, string>
        {
            { typeof(string), "string" },
            { typeof(decimal), "number" },
            { typeof(bool), "boolean" },
            { typeof(List<AphidObject>), "list" },
            { typeof(AphidObject), "object" },
            { typeof(AphidFunction), "function" },
        };

        public ValueHelper(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public object Unwrap(object obj)
        {
            AphidObject aphidObj;

            return (aphidObj = obj as AphidObject) != null ? aphidObj.Value : obj;
        }

        public AphidObject Wrap(object obj)
        {
            AphidObject aphidObj;

            return (aphidObj = obj as AphidObject) != null ? aphidObj : new AphidObject(obj);
        }

        public object DeepUnwrap(object obj)
        {
            AphidObject aphidObj;
            List<AphidObject> list;

            if ((list = obj as List<AphidObject>) != null)
            {
                return list.Select(DeepUnwrap).ToArray();
            }
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

        public object UnwrapAndBoxCollection(object obj)
        {
            var o = Unwrap(obj);
            var t = o.GetType();

            if (t.IsArray)
            {
                var elementType = t.GetElementType();

                if (!elementType.IsEnum && !elementType.IsPrimitive)
                {
                    return o;
                }

                var src = (Array)o;
                var dst = new object[src.Length];
                Array.Copy(src, dst, src.Length);

                return dst;
            }

            var interfaces = t
                .GetInterfaces()
                .Where(x =>
                    x.IsGenericType &&
                    x.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                .ToArray();

            if (interfaces.Any())
            {
                var target = interfaces.First();
                var elementType = target.GetGenericArguments().First();

                if (!elementType.IsEnum && !elementType.IsPrimitive)
                {
                    return o;
                }

                return ((IEnumerable)o).Cast<object>();
            }

            return o;
        }

        public void AssertString(object value, string operation)
        {
            AssertValue<string>(value, operation);
        }

        public void AssertNumber(object value, string operation)
        {
            AssertValue<decimal>(value, operation);
        }

        public void AssertBool(object value, string operation)
        {
            AssertValue<bool>(value, operation);
        }

        public void AssertList(object value, string operation)
        {
            AssertValue<List<AphidObject>>(value, operation);
        }

        public void AssertObject(object value, string operation)
        {
            AssertValue<AphidObject>(value, operation);
        }

        public void AssertFunction(object value, string operation)
        {
            AssertValue<AphidFunction>(value, operation);
        }

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

        public string GetTypeName(Type type)
        {
            return _typeName[type];
        }

        public string GetTypeName<T>()
        {
            return _typeName[typeof(T)];
        }

        public string GetTypeName(object value)
        {
            return value != null ? _typeName[value.GetType()] : "null";
        }

        public bool IsComplexAphidObject(object obj)
        {
            var ao = obj as AphidObject;

            return ao != null && ao.Value == null;
        }
    }

    public class ValueHelper<TExpected>
    {
        
    }
}
