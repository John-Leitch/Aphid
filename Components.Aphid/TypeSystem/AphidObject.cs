//#define LOW_SECURITY
//#define STRICT_APHID_OBJECT_TYPE_CHECKS
//#define DETECTED_ERRONEOUS_NESTING
//#define APHID_OBJECT_OWNER_THREAD
using Components.Aphid.Interpreter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace Components.Aphid.TypeSystem
{
    [Serializable]
    public partial class AphidObject : Dictionary<string, AphidObject>
    {
        private bool _isScalar;

        public bool IsScalar
        {
            get { return _isScalar; }
            set
            {
                _isScalar = value;
                _isComplex = !value;
            }
        }

        private bool _isComplex;

        public bool IsComplex
        {
            get { return _isComplex; }
            set
            {
                _isComplex = value;
                _isScalar = !value;
            }
        }

        public bool IsComplexitySet
        {
            get { return _isScalar || _isComplex; }
        }

#if STRICT_APHID_OBJECT_TYPE_CHECKS
        private object _value;

        public object Value
        {
            get { return _value; }
            set
            {
#if DETECTED_ERRONEOUS_NESTING
                if (value != null && value.GetType() == typeof(AphidObject))
                {
                    throw new InvalidOperationException();
                }
#endif

                if (IsComplexitySet)
                {
                    if (_isComplex)
                    {
                        throw new InvalidOperationException();
                    }
                }
                else
                {
                    _isScalar = true;
                    _isComplex = false;
                }

                _value = value;
            }
        }
#else
        public object Value { get; set; }
#endif

#if APHID_OBJECT_OWNER_THREAD
        public int OwnerThread { get; private set; }
#endif

        public AphidObject Parent { get; set; }

        private AphidObject()
            : this(isScalar: false)
        {
            //OwnerThread = Thread.CurrentThread.ManagedThreadId;
        }

        private AphidObject(object value)
            : this(isScalar: true)
        {
            Value = value;
        }

        private AphidObject(AphidObject parent)
            : this(isScalar: false)
        {
            //if (parent == null)
            //{
            //    throw new InvalidOperationException();
            //}

            Parent = parent;
        }

        private AphidObject(bool isScalar)
        {
#if APHID_OBJECT_OWNER_THREAD
            OwnerThread = Thread.CurrentThread.ManagedThreadId;
#endif

            IsScalar = isScalar;
        }

#if !LOW_SECURITY
        protected AphidObject(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Todo: eliminate strings
            _isScalar = info.GetBoolean("_isScalar");
            _isComplex = info.GetBoolean("_isComplex");
#if STRICT_APHID_OBJECT_TYPE_CHECKS
            _value = info.GetValue("_value", typeof(object));
#else
            Value = info.GetValue("_value", typeof(object));
#endif
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_isScalar", _isScalar);
            info.AddValue("_isComplex", _isComplex);
#if STRICT_APHID_OBJECT_TYPE_CHECKS
            info.AddValue("_value", _value);
#else
            info.AddValue("_value", Value);
#endif

            base.GetObjectData(info, context);
        }
#endif

        public override string ToString()
        {
            return ToString(printMembers: true);
        }

        private string ToString(bool printMembers)
        {
            return _isScalar ? Value.ToString() :
                printMembers ? string.Format(
                    "{{ {0} }}",
                    this
                        .Select(x => string.Format(
                            "{0}: {1}",
                            x.Key,
                            x.Value != null ? x.Value.ToString(false) : null))
                        .Join(", ")) :
                "{ ... }";
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
            return GetValueType(true);
        }

        public string GetValueType(bool includeClrTypes)
        {
            Type t;

            return
                Value != null ? AphidAlias.Resolve(t = Value.GetType()) ??
                    (includeClrTypes ? t.FullName : AphidType.Unknown) :
                IsScalar ? AphidType.Null :
                AphidType.Object;
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
            if (obj.IsComplex)
            {
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
            else
            {
                obj.Value = Value;
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
                return AphidObject.Scalar(Convert.ToDecimal(o));
            }
            else if (t.IsPrimitive || t == typeof(string) || t == typeof(decimal))
            {
                return AphidObject.Scalar(o);
            }
            else if ((enumerable = o as IEnumerable) != null)
            {
                var items = new List<AphidObject>();

                foreach (var element in enumerable)
                {
                    items.Add(ConvertFrom(element.GetType(), element));
                }

                return AphidObject.Scalar(items);
            }
            else
            {
                var ao = AphidObject.Complex();
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

        public AphidObject Resolve(AphidInterpreter interpreter, string key, string errorMessage = null)
        {
            AphidObject obj;

            if (!TryResolve(key, out obj))
            {
                throw errorMessage == null ?
                    interpreter.CreateValueException(this, "Could not resolve property {0}", key) :
                    interpreter.CreateValueException(this, errorMessage);
            }

            return obj;
        }

        public bool TryResolve(string key, out AphidObject value)
        {
#if STRICT_APHID_OBJECT_TYPE_CHECKS
            if (IsScalar)
            {
                throw new InvalidOperationException();
            }
#endif

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

        public AphidObject TryResolveParent(string key)
        {
            AphidObject value;

            if (TryGetValue(key, out value))
            {
                return this;
            }
            else if (Parent != null)
            {
                return Parent.TryResolveParent(key);
            }
            else
            {
                return null;
            }
        }

        public bool IsDefined(string key)
        {
            AphidObject v;

            return TryResolve(key, out v);
        }

        public bool ResolveBool(string key)
        {
            AphidObject value;

            return
                TryResolve(key, out value) &&
                value.Value != null &&
                Convert.ToBoolean(value.Value);
        }

        public bool IsAphidType()
        {
            return IsAphidType(this.Value);
        }

        public AphidObject[] FlattenScope()
        {
            var scope = this;
            var scopes = new List<AphidObject> { this };

            while ((scope = scope.Parent) != null)
            {
                scopes.Add(scope);
            }

            return scopes.ToArray();
        }

        public string GetTypeName()
        {
            return Count > 0 ? AphidType.Object :
                Value != null ? GetValueType() :
                AphidType.Null;
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = base.GetHashCode();

                if (hash == 0)
                {
                    hash = 0x100000;
                }

                hash += _isScalar ? 0x10 : 0x100;
                hash += _isComplex ? 0x20 : 0x200;

#if STRICT_APHID_OBJECT_TYPE_CHECKS
                var tmp = _value != null ?_value.GetHashCode() : 0x300;
#else
                var tmp = Value != null ? Value.GetHashCode() : 0x300;
#endif
                hash += tmp != 0 ? tmp : 0x400;

#if APHID_OBJECT_OWNER_THREAD
                tmp = OwnerThread.GetHashCode();
                hash += tmp != 0 ? tmp : 0x500;
#endif

                tmp = Parent != null ? Parent.GetHashCode() : 0x600;
                hash += tmp != 0 ? tmp : 0x700;
                //hash = ((hash * ~hash) ^ hash) * hash;

                return hash;
            }
        }

        public AphidObject CreateChild()
        {
            return new AphidObject(this);
        }

        public static AphidObject Scalar(object value)
        {
            return new AphidObject(value: value);
        }

        public static AphidObject Scope()
        {
            return new AphidObject();
        }

        public static AphidObject Complex()
        {
            return new AphidObject();
        }

        public static AphidObject Complex(IEnumerable<KeyValuePair<string, AphidObject>> members)
        {
            var obj = new AphidObject();
            

            foreach (var m in members)
            {
                obj.Add(m.Key, m.Value);
            }

            return obj;
        }

        public static AphidObject Scope(AphidObject parentScope)
        {
            return parentScope != null ? new AphidObject(parentScope) : AphidObject.Complex();
        }

        public static AphidObject Null()
        {
            return new AphidObject(value: null);
        }
    }
}
