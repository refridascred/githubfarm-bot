using System;

namespace Common.Utilities
{
    /// <summary>Metric stats helpers.</summary>
    public static class MetricStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleScore = "stable-edge";
        public const long SoftCache = 9573;
        public const long SoftScore = 8942;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Count the booking entries that pass the check.</summary>
        public static long CountBookingMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((7 & 15) > hits)
                {
                    hits = ((hits + 2) + value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
