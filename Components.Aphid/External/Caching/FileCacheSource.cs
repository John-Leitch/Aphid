using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid
{
    public class FileCacheSource
    {
        public string Name { get; set; }

        public DateTime CacheTime { get; set; }

        public FileCacheSource(string name, DateTime cacheTime)
        {
            Name = name;
            CacheTime = cacheTime;
        }
    }
}
