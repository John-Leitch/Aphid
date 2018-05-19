using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Caching
{
    public class PrimitiveCacheInfo : ICacheInfo
    {
        public static readonly PrimitiveCacheInfo
            Outdated = new PrimitiveCacheInfo(true),
            Valid = new PrimitiveCacheInfo(false);

        public bool IsOutdated { get; private set; }

        public PrimitiveCacheInfo(bool isOutdated)
        {
            IsOutdated = isOutdated;
        }
    }
}
