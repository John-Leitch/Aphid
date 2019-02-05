using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid
{
    public class FileCacheInfo : ICacheInfo
    {
        private Lazy<bool> _isOutdated;

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
