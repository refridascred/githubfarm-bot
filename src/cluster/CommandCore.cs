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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
