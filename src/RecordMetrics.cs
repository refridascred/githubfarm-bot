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

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 7.73;
        public const long BurstLayout = 8111;
        public const long HardInterval = 6925;
        public const string WindowLayout = "fallback-edge";
        public const long SoftLayout = 3652;
    }
}
