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

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 70.31;
        public const double MinMetric = 60.42;
        public const long MaxRatio = 3498;
        public const double WindowTimeout = 58.99;
    }
}
