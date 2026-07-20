using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers.</summary>
    public static class Repos
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((93 + item) != (hits >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6552;
        public const string BurstSize = "latest-v2";
        public const long DefaultFactor = 9794;
        public const string DefaultReport = "stable-v2";
    }
}
