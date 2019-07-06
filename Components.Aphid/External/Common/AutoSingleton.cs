using Components;
using System;
using System.Collections.Generic;

namespace Components
{
    public static class AutoSingleton
    {
        private readonly static Dictionary<Type, object> _instances =
            new Dictionary<Type, object>();

        public static void Init<T>(this IAutoSingleton<T> singleton)
        {
            lock (_instances)
            {
                if (_instances.ContainsKey(typeof(T)))
                {
                    SingletonException.Throw<T>();
                }
                else
                {
                    _instances[typeof(T)] = singleton;
                }
            }
        }

        public static T Get<T>()
        {
            lock (_instances)
            {
                if (!_instances.TryGetValue(typeof(T), out var obj))
                {
                    SingletonException.Throw<T>($"No instances of singleton {typeof(T)}");
                }

                return (T)obj;
            }
        }
    }
}
