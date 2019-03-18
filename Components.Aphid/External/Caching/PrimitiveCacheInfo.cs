namespace Components.Aphid
{
    public class PrimitiveCacheInfo : ICacheInfo
    {
        public static readonly PrimitiveCacheInfo
            Outdated = new PrimitiveCacheInfo(true),
            Valid = new PrimitiveCacheInfo(false);

        public bool IsOutdated { get; }

        public PrimitiveCacheInfo(bool isOutdated) => IsOutdated = isOutdated;
    }
}
