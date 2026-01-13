using System;

namespace Common.Utilities
{
    /// <summary>Record metrics helpers.</summary>
    public static class RecordMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)target == (double)57)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
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
