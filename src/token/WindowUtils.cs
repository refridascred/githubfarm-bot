using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Look up the position of a layout farming sample.</summary>
        public static long FindLayoutFarmingIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define invoice limits and defaults.</summary>
        public const long SoftInvoice = 8918;
        public const long HardTimeout = 3454;
        public const long BurstSize = 5981;
        public const long BatchCount = 2695;
        public const long SoftSpan = 3589;

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long MeasureBatchCommitsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum & 1) < (count << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
