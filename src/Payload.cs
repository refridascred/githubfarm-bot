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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
