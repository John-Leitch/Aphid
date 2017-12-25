using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Interpreter
{
    public partial class AphidObject : Dictionary<string, AphidObject>
    {
        public AphidObject Parent { get; set; }

        public object Value { get; set; }

        public AphidObject()
        {
        }

        public AphidObject(object value)
        {
            Value = value;
        }

        public AphidObject(object value, AphidObject parent)
        {
            Value = value;
            Parent = parent;
        }

        public override string ToString()
        {
            return string.Format("{{ {0}, {1} members }}", Value, Count);
        }

        public List<AphidObject> GetList()
        {
            return Value as List<AphidObject>;
        }

        public IEnumerable<string> GetStringList()
        {
            return GetList().Select(x => x.GetString());
        }

        public string GetString()
        {
            return Value as string;
        }

        public decimal GetNumber()
        {
            return (decimal)Value;
        }

        public bool GetBool()
        {
            return (bool)Value;
        }

        public AphidFunction GetFunction()
        {
            return Value as AphidFunction;
        }

        public string GetValueType()
        {
            return Value != null ? 
                AphidAlias.Resolve(Value.GetType()) ?? AphidType.Unknown :
                AphidType.Null;
        }

        private static IEnumerable<AphidPropertyInfo> GetPropertyInfo(object obj)
        {
            return obj
                .GetType()
                .GetProperties()
                .Select(x => new
                {
                    Property = x,
                    AphidProperty = x
                        .GetCustomAttributes(true)
                        .OfType<AphidPropertyAttribute>()
                        .FirstOrDefault(),
                })
                .Where(x => x.AphidProperty != null)
                .Select(x => new AphidPropertyInfo(
                    x.AphidProperty.Name ?? x.Property.Name,
                    x.Property));
        }

        private IEnumerable<AphidPropertyValuePair> GetPropertyValuePairs(object obj)
        {
            return GetPropertyInfo(obj)
                .Where(x => ContainsKey(x.Name))
                .Select(x => new AphidPropertyValuePair(x.Property, this[x.Name]));
        }

        public void Bind(object obj, bool invokeEvents = true)
        {
            var bindable = obj as IAphidBindable;

            if (invokeEvents && bindable != null)
            {
                bindable.OnBinding(this);
            }

            var kvps = GetPropertyValuePairs(obj);

            foreach (var p in kvps)
            {
                if (TrySetProperty(p.Property, obj, p.Value))
                {
                    continue;
                }
                else if (p.Property.PropertyType.IsArray)
                {
                    var elementType = p.Property.PropertyType.GetElementType();
                    var srcArray = p.Value
                        .GetList()
                        .Select(x =>
                        {
                            var element = Activator.CreateInstance(elementType);
                            x.Bind(element);
                            return element;
                        })
                        .ToArray();
                    var destArray = Array.CreateInstance(elementType, srcArray.Length);
                    Array.Copy(srcArray, destArray, srcArray.Length);

                    p.Property.SetValue(obj, destArray, null);
                }
                else if (p.Property.PropertyType.IsEnum)
                {
                    var val = Enum.ToObject(p.Property.PropertyType, Convert.ToInt64(p.Value.Value));
                    p.Property.SetValue(obj, val, null);
                }
                else if (p.Value.Count == 0 ||
                    p.Property.PropertyType == typeof(bool) ||
                    p.Property.PropertyType == typeof(string) ||
                    p.Property.PropertyType == typeof(decimal))
                {
                    p.Property.SetValue(obj, p.Value.Value, null);
                }
                else
                {
                    var childObj = Activator.CreateInstance(p.Property.PropertyType);
                    p.Value.Bind(childObj);
                    p.Property.SetValue(obj, childObj, null);
                }
            }

            if (invokeEvents && bindable != null)
            {
                bindable.OnBound(this);
            }
        }

        public T ConvertTo<T>()
            where T : new()
        {
            var obj = new T();
            Bind(obj);

            return obj;
        }

        public TElement[] ConvertToArray<TElement>()
            where TElement : new()
        {
            var list = GetList();
            var array = new TElement[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i].ConvertTo<TElement>();
            }

            return array;
        }

        public void CopyTo(AphidObject obj)
        {
            obj.Value = Value;

            foreach (var nvp in this)
            {
                if (obj.ContainsKey(nvp.Key))
                {
                    obj[nvp.Key] = nvp.Value;
                }
                else
                {
                    obj.Add(nvp.Key, nvp.Value);
                }
            }
        }

        public static AphidObject ConvertFrom(Type t, object o)
        {
            IEnumerable enumerable;

            if (t == typeof(sbyte) ||
                t == typeof(byte) ||
                t == typeof(short) ||
                t == typeof(ushort) ||
                t == typeof(int) ||
                t == typeof(uint) ||
                t == typeof(long) ||
                t == typeof(ulong) ||
                t == typeof(float) ||
                t == typeof(double))
            {
                return new AphidObject(Convert.ToDecimal(o));
            }
            else if (t.IsPrimitive || t == typeof(string) || t == typeof(decimal))
            {
                return new AphidObject(o);
            }
            else if ((enumerable = o as IEnumerable) != null)
            {
                var items = new List<AphidObject>();

                foreach (var element in enumerable)
                {
                    items.Add(ConvertFrom(element.GetType(), element));
                }

                return new AphidObject(items);
            }
            else
            {
                var ao = new AphidObject();
                var properties = GetPropertyInfo(o);

                foreach (var p in properties)
                {
                    var val = ConvertFrom(
                        p.Property.PropertyType,
                        p.Property.GetValue(o, null));

                    ao.Add(p.Name, val);
                }

                return ao;
            }
        }

        public static AphidObject ConvertFrom<T>(T o)
        {
            return ConvertFrom(typeof(T), o);
        }

        public AphidObject Resolve(string key, string errorMessage = null)
        {
            AphidObject obj;

            if (!TryResolve(key, out obj))
            {
                throw new AphidRuntimeException(
                    errorMessage ?? 
                    string.Format("Could not resolve {0}.", key));
            }

            return obj;
        }

        public bool TryResolve(string key, out AphidObject value)
        {
            if (TryGetValue(key, out value))
            {
                return true;
            }
            else if (Parent != null)
            {
                return Parent.TryResolve(key, out value);
            }
            else
            {
                return false;
            }
        }

        public bool TryResolveAndRemove(string key)
        {
            if (ContainsKey(key))
            {
                Remove(key);
                return true;
            }
            else if (Parent != null)
            {
                return Parent.TryResolveAndRemove(key);
            }
            else
            {
                return false;
            }
        }

        public bool IsDefined(string key)
        {
            AphidObject v;

            return TryResolve(key, out v);
        }

        public bool IsAphidType()
        {
            return IsAphidType(this.Value);
        }

        public static bool IsAphidType(object obj)
        {
            return
                obj == null ||
                obj is string ||
                obj is decimal ||
                obj is bool ||
                obj is List<AphidObject> ||
                obj is AphidObject ||
                obj is AphidFunction ||
                obj is AphidInteropFunction;
        }
    }
}
