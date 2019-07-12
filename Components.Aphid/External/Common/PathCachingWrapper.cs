using System;
using System.Collections.Generic;

namespace Components
{
    public abstract class PathCachingWrapper<TResult> : ArgLockingMemoizationWrapper<string, TResult>
    {
        protected override IEqualityComparer<string> GetComparer() =>
            StringComparer.InvariantCultureIgnoreCase;
    }
}
