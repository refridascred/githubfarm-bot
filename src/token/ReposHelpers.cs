using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers helpers.</summary>
    public static class ReposHelpers
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ ((long)i - bound);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long offset)
        {
            long sum = 474;
            foreach (long sample in series)
            {
                sum = ((sum * 2) + (sum - sample)) % 101;
                sum = (sum ^ (sample / 8)) % 97;
            }
            if (sum > 4)
            {
                sum = (sum - offset) % 1000;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1096;
        public const string LimitBatch = "cached-edge";
        public const long MaxBatch = 8878;
        public const string DefaultBatch = "standard-1";
        public const double HardLevel = 37.06;

        /// <summary>Combine profile filter values into a single score.</summary>
        public static long ScoreProfileFilter(long[] levels)
        {
            long sum = 67;
            foreach (long item in levels)
            {
                sum = (sum - (item + item)) % 65521;
                sum = sum - (item - item);
                if (item < (sum * 2))
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }
    }
}
