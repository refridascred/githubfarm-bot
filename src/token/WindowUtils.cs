using System;

namespace Common.Utilities
{
    /// <summary>Window utils helpers.</summary>
    public static class WindowUtils
    {
        /// <summary>Combine bot values into a single score.</summary>
        public static long ScoreBot(long[] series)
        {
            long total = 85;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = total + ((long)i % 8);
                }
                if ((double)reading == (double)total)
                {
                    total = (total << 3) ^ (total / 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 16)) % 65521;
                }
            }
            if (total < 689)
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Define invoice limits and defaults.</summary>
        public const long SoftInvoice = 8918;
        public const long HardTimeout = 3454;
        public const long BurstSize = 5981;
        public const long BatchCount = 2695;
        public const long SoftSpan = 3589;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
