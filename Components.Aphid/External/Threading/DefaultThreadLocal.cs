using System.Threading;

namespace Components.Threading
{
    public class DefaultThreadLocal<T> : ThreadLocal<T>
        where T : new()
    {
        private static T NextValue() => new T();

        public DefaultThreadLocal()
            : base(NextValue)
        {
        }

        public DefaultThreadLocal(bool trackAllValues)
            : base(NextValue, trackAllValues)
        {
        }
    }
}
