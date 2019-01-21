//#define LOW_SECURITY
//#define STRICT_APHID_OBJECT_TYPE_CHECKS
//#define DETECTED_ERRONEOUS_NESTING
//#define APHID_OBJECT_OWNER_THREAD
//#define CHECK_COMPLEXITY_SET
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
    public sealed partial class AphidObject : Dictionary<string, AphidObject>
    {
        public const int MaxToStringMembers = 0x8;

        public static readonly AphidObject
            InternedNull = Scalar(null),
            InternedTrue = Scalar(true),
            InternedFalse = Scalar(false);

#if STRICT_APHID_OBJECT_TYPE_CHECKS
        private bool _isScalar;

        public bool IsScalar
        {
            get { return _isScalar; }
            private set
            {
                _isScalar = value;
                _isComplex = !value;
            }
        }

        private bool _isComplex;

        public bool IsComplex
        {
            get { return _isComplex; }
            private set
            {
                _isComplex = value;
                _isScalar = !value;
            }
        }
#else
        public bool IsScalar { get; }

        public bool IsComplex { get; }
#endif       

#if CHECK_COMPLEXITY_SET
        public bool IsComplexitySet
        {
            get { return _isScalar || _isComplex; }
        }
#else
        public bool IsComplexitySet => true;
#endif

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
        {
            IsComplex = true;

#if APHID_OBJECT_OWNER_THREAD
            OwnerThread = Thread.CurrentThread.ManagedThreadId;
#endif
        }

        private AphidObject(object value)
        {
            IsScalar = true;
            Value = value;

#if APHID_OBJECT_OWNER_THREAD
            OwnerThread = Thread.CurrentThread.ManagedThreadId;
#endif      
        }

        private AphidObject(AphidObject parent)
        {
            IsComplex = true;
            Parent = parent;

#if APHID_OBJECT_OWNER_THREAD
            OwnerThread = Thread.CurrentThread.ManagedThreadId;
#endif
        }

#if !LOW_SECURITY
#pragma warning disable CS0628 // New protected member declared in sealed class
        protected AphidObject(SerializationInfo info, StreamingContext context)
#pragma warning restore CS0628 // New protected member declared in sealed class
            : base(info, context)
        {
            // Todo: eliminate strings
            IsScalar = info.GetBoolean("_isScalar");
            IsComplex = info.GetBoolean("_isComplex");
#if STRICT_APHID_OBJECT_TYPE_CHECKS
            _value = info.GetValue("_value", typeof(object));
#else
            Value = info.GetValue("_value", typeof(object));
#endif
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_isScalar", IsScalar);
            info.AddValue("_isComplex", IsComplex);
#if STRICT_APHID_OBJECT_TYPE_CHECKS
            info.AddValue("_value", _value);
#else
            info.AddValue("_value", Value);
#endif

            base.GetObjectData(info, context);
        }
#endif

        public override string ToString() => ToString(printMemberValues: true);

        private string ToString(bool printMemberValues) =>
            IsScalar ? (Value == null ? AphidType.Null : Value.ToString()) :
            printMemberValues ? ToString(this, printMemberValues) :
            "{ ... }";

        private static string ToString(AphidObject x, bool printMemberValues) =>
            $"{{ {x.Where(y => !y.Key.StartsWith("$")).Take(MaxToStringMembers).Select(y => ToString(y, printMemberValues)).Join(", ")}{(x.Count > MaxToStringMembers ? ", ..." : "")} }}";

        private static string ToString(KeyValuePair<string, AphidObject> x, bool printMemberValues) =>
            printMemberValues ?
                $"{x.Key}: {(x.Value != null ? x.Value.ToString(false) : AphidType.Null)}" :
                x.Key;

        public List<AphidObject> GetList() => Value as List<AphidObject>;

        public IEnumerable<string> GetStringList() => GetList().Select(x => x.GetString());

        public string GetString() => Value as string;

        public decimal GetNumber() => (decimal)Value;

        public bool GetBool() => (bool)Value;

        public AphidFunction GetFunction() => Value as AphidFunction;

        public string GetValueType() => GetValueType(true);

        public string GetValueType(bool includeClrTypes)
        {
            if (IsScalar)
            {
                if (Value != null)
                {
                    var t = Value.GetType();
                    var name = AphidAlias.Resolve(t);

                    if (name != null)
                    {
                        return name;
                    }
                    else if (includeClrTypes)
                    {
                        return t.FullName;
                    }
                    else
                    {
                        return AphidType.Unknown;
                    }
                }
                else
                {
                    return AphidType.Null;
                }
            }
            else
            {
                return AphidType.Object;
            }
        }

        private static IEnumerable<AphidPropertyInfo> GetPropertyInfo(object obj) =>
            GetPropertyInfo(obj, allProperties: false);

        private static IEnumerable<AphidPropertyInfo> GetPropertyInfo(object obj, bool allProperties) =>
            obj
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
                .Where(x => x.AphidProperty != null || allProperties)
                .Select(x => new AphidPropertyInfo(
                    x?.AphidProperty?.Name ?? x.Property.Name,
                    x.Property));

        private IEnumerable<AphidPropertyValuePair> GetPropertyValuePairs(object obj) =>
            GetPropertyInfo(obj)
                .Where(x => ContainsKey(x.Name))
                .Select(x => new AphidPropertyValuePair(x.Property, this[x.Name]));

        public void Bind(object obj, bool invokeEvents = true)
        {
            var bindable = obj as IAphidBindable;

            if (invokeEvents && bindable != null)
            {
                bindable.OnBinding(this);
            }

            foreach (var p in GetPropertyValuePairs(obj))
            {
                var property = p.Property;

                if (TrySetProperty(property, obj, p.Value))
                {
                    continue;
                }
                else if (property.PropertyType.IsArray)
                {
                    var elementType = property.PropertyType.GetElementType();
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
                    property.SetValue(obj, destArray, null);
                }
                else if (property.PropertyType.IsEnum)
                {
                    var val = Enum.ToObject(property.PropertyType, Convert.ToInt64(p.Value.Value));
                    property.SetValue(obj, val, null);
                }
                else if (p.Value.Count == 0 ||
                    property.PropertyType == typeof(bool) ||
                    property.PropertyType == typeof(string) ||
                    property.PropertyType == typeof(decimal))
                {
                    property.SetValue(obj, p.Value.Value, null);
                }
                else
                {
                    var childObj = Activator.CreateInstance(property.PropertyType);
                    p.Value.Bind(childObj);
                    property.SetValue(obj, childObj, null);
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

        public static AphidObject ConvertFrom(Type t, object o) => ConvertFrom(t, o, allProperties: false);

        public static AphidObject ConvertFrom(Type t, object o, bool allProperties)
        {
            IEnumerable enumerable;

            if (t.IsPrimitive ||
                t == typeof(string) ||
                t == typeof(decimal) ||
                t == typeof(sbyte) ||
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
                return Scalar(o);
            }
            else if ((enumerable = o as IEnumerable) != null)
            {
                var items = new List<AphidObject>();

                foreach (var element in enumerable)
                {
                    items.Add(ConvertFrom(element.GetType(), element, allProperties));
                }

                return Scalar(items);
            }
            else
            {
                var ao = Complex();

                foreach (var p in GetPropertyInfo(o, allProperties))
                {
                    var val = ConvertFrom(p.Property.PropertyType, p.Property.GetValue(o, null));
                    ao.Add(p.Name, val);
                }

                return ao;
            }
        }

        public static AphidObject ConvertFrom<T>(T o) =>
            ConvertFrom(typeof(T), o, allProperties: false);

        public static AphidObject ConvertFrom<T>(T o, bool allProperties) =>
            ConvertFrom(typeof(T), o, allProperties);

        public AphidObject Resolve(AphidInterpreter interpreter, string key, string errorMessage = null)
        {
            if (!TryResolve(key, out var obj))
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
            if (TryGetValue(key, out var value))
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

        public bool IsDefined(string key) => TryResolve(key, out var v);

        public bool ResolveBool(string key) =>
            TryResolve(key, out var value) &&
                value.Value != null &&
                Convert.ToBoolean(value.Value);

        public bool IsAphidType() => IsAphidType(Value);

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
            if (IsComplex)
            {
                return AphidType.Object;
            }
            else if (Value != null)
            {
                return GetValueType();
            }
            else
            {
                return AphidType.Null;
            }
        }

        public static bool IsAphidType(object obj)
        {
            if (obj == null)
            {
                return true;
            }
            else
            {
                var t = obj.GetType();

                return
                    t == typeof(string) ||
                    t == typeof(decimal) ||
                    t == typeof(bool) ||
                    t == typeof(List<AphidObject>) ||
                    t == typeof(AphidObject) ||
                    t == typeof(AphidFunction) ||
                    t == typeof(AphidInteropFunction);
            }
        }

        public override bool Equals(object obj) => base.Equals(obj);

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = base.GetHashCode();

                if (hash == 0)
                {
                    hash = 0x100000;
                }

                hash += IsScalar ? 0x10 : 0x100;
                hash += IsComplex ? 0x20 : 0x200;

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

        public AphidObject CreateChild() => new AphidObject(this);

        public static AphidObject Scalar(object value) => new AphidObject(value: value);

        public static AphidObject Scope() => new AphidObject();

        public static AphidObject Complex() => new AphidObject();

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
            if (parentScope != null)
            {
                return new AphidObject(parentScope);
            }
            else
            {
                return new AphidObject();
            }
        }
    }
}
