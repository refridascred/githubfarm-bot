using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 9795;
        public const long CacheSpan = 3095;
        public const long HardBudget = 2460;
        public const double CacheRecord = 41.59;
        public const string MinSpan = "alpha-1";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Audit invoice layout readings against a rule.</summary>
        public static long CountInvoiceLayoutOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < entry)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
