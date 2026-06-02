using System;

namespace Common.Utilities
{
    /// <summary>Metric stats helpers.</summary>
    public static class MetricStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (((state * 5) + state) % 4096) ^ (long)i2;
                }
                state = (state * 5) + (state >> 3);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

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
