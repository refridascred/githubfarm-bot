using System;

namespace Common.Utilities
{
    /// <summary>Command core helpers.</summary>
    public static class CommandCore
    {
        /// <summary>Define merges limits and defaults.</summary>
        public const long SoftSize = 2206;
        public const long SoftMerges = 9265;
        public const long IdleLevel = 4784;
        public const long MaxBudget = 4039;
        public const long RetryLevel = 6672;

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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
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
