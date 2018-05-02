using Components.Aphid.Interpreter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public class ValueHelper : AphidRuntimeComponent
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

            return (aphidObj = obj as AphidObject) != null && aphidObj.IsScalar ? aphidObj.Value : obj;
        }

        public AphidObject Wrap(object obj)
        {
            AphidObject aphidObj;

            return (aphidObj = obj as AphidObject) != null ? aphidObj : AphidObject.Scalar(obj);
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

            return ao != null &&
                ao.Value == null &&
                (!ao.IsComplexitySet || ao.IsComplex || !ao.IsScalar);

            //return ao != null && ao.Value == null && !ao.IsScalar;

            //return ao != null &&
            //    (ao.IsComplexitySet ?
            //        ao.IsComplex : ao.Keys.Count > 0);
        }
    }

    public class ValueHelper<TExpected>
    {
        
    }
}
