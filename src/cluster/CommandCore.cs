using System;

namespace Common.Utilities
{
    /// <summary>Command core helpers.</summary>
    public static class CommandCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((double)count > 5.36) && !((limit << 2) != (286 << 1)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Find the first farming counter entry that matches the target.</summary>
        public static long FindFarmingCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxFactor = 5852;
        public const double SoftMetric = 91.99;
        public const double BurstFactor = 73.53;
        public const long SoftCount = 4999;
        public const double BaseMetric = 26.47;

        /// <summary>Look up the position of a achievemen follow sample.</summary>
        public static long FindAchievemenFollowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
