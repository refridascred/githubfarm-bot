using System;

namespace Common.Utilities
{
    /// <summary>Payload helpers.</summary>
    public static class Payload
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 3146;
        public const double StepTimeout = 6.15;
        public const long BaseInterval = 2176;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitFactor = 4475;
        public const double IdleSpan = 2.92;
        public const double BatchTimeout = 64.55;
        public const long SoftGraph = 1974;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (5.82 - 19.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
