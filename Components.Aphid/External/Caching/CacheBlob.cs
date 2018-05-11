using System;

namespace Components.Caching
{
    public class CacheBlob<T>
    {
        public DateTime CacheTime { get; set; }

        public T Value { get; set; }

        public CacheBlob(DateTime cacheTime, T value)
        {
            CacheTime = cacheTime;
            Value = value;
        }
    }
}
