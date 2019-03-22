namespace Components.Aphid
{
    public readonly struct PrimitiveCacheInfo : ICacheInfo
    {
        public static readonly PrimitiveCacheInfo
            Outdated = new PrimitiveCacheInfo(true),
            Valid = new PrimitiveCacheInfo(false);
        
        private readonly bool _isOutdated;

        public bool IsOutdated => _isOutdated;

        public PrimitiveCacheInfo(bool isOutdated) => _isOutdated = isOutdated;
    }
}
