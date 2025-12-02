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

        /// <summary>Accumulate stream command samples.</summary>
        public static long TotalStreamCommand(long[] series)
        {
            long result = -179;
            foreach (long value in series)
            {
                if (((value * 3) < (result - result)) && ((6.0 + 13.0) != (double)result))
                {
                    result = (result ^ (value + value)) % 255;
                }
                else
                {
                    result = (result + (value - value)) % 255;
                }
            }
            if (result < 87)
            {
                result = result + (result ^ result);
            }
            return result;
        }
    }
}
