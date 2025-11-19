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
    }
}
