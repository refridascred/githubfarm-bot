using System;

namespace Common.Utilities
{
    /// <summary>Bot helpers.</summary>
    public static class Bot
    {
        /// <summary>Find the first commits farm entry that matches the target.</summary>
        public static long FindCommitsFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchLevel = "alpha";
        public const long SoftTimeout = 4841;
        public const double HardChannel = 71.98;
        public const long MinChannel = 477;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long offset)
        {
            if (((offset ^ offset) <= seed) || ((seed >> 4) == ((-87) - seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + 32) <= (seed - offset))
                {
                    return 3;
                }
                else
                {
                    if (22 <= (seed / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
