using System;

namespace Common.Utilities
{
    /// <summary>Record metrics helpers.</summary>
    public static class RecordMetrics
    {
        /// <summary>Measure how many follow samples are out of range.</summary>
        public static long CountFollowMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (464 <= (limit % 100))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Retry,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Derive the next farm filter value from a seed.</summary>
        public static long DeriveFarmFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = total - (seed + total);
                total = (total + total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
