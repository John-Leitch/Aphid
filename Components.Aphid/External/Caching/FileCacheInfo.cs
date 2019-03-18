using System;
using System.Linq;

namespace Components.Aphid
{
    public class FileCacheInfo : ICacheInfo
    {
        private readonly Lazy<bool> _isOutdated;

        public bool IsOutdated => _isOutdated.Value;

        public FileCacheSource[] Sources { get; }

        public FileCacheInfo(FileCacheSource[] sources)
        {
            Sources = sources;
            _isOutdated = new Lazy<bool>(GetIsOutdated);
        }

        private bool GetIsOutdated() =>
            Sources.Any(x => x.File.LastWriteTimeUtc != x.CacheTime);
    }
}
