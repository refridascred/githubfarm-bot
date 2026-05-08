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

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((anchor << 1) > (anchor / 4)))
                {
                    anchor = (anchor << 3) ^ ((long)i & 31);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate cursor readings against a bound.</summary>
        public static bool CheckCursorRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinSize = 50;
        public const long LimitLevel = 7710;
        public const double SoftWindow = 13.95;
        public const long MaxInterval = 821;
    }
}
