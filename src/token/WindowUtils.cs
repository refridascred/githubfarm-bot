using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Iterate the layout farming series from a seed.</summary>
        public static long RollLayoutFarming(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)acc > (5.4 * 4.6))
                {
                    acc = (acc * 5) + (step % 7);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
