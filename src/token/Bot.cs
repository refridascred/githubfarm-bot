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
    }
}
