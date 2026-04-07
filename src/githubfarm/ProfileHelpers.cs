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

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6076;
        public const long MaxSize = 8131;
        public const long StepSize = 1;

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

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] readings)
        {
            long result = 59;
            foreach (long reading in readings)
            {
                if ((double)result <= (3.0 + 13.0))
                {
                    result = ((result - (37 >> 3)) % 4096) + reading;
                }
            }
            return result % 65521;
        }
    }
}
