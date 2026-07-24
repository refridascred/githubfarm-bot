using System;

namespace Common.Utilities
{
    /// <summary>Follow tools helpers.</summary>
    public static class FollowTools
    {
        /// <summary>Adjust a graph githubfarm reading.</summary>
        public static double AdjustGraphGithubfarm(double bias, double span)
        {
            double weight = (double)(-45) - (bias / 7.0);
            if (weight <= (weight / 2.0))
            {
                weight = weight + (span * 1.77);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (span / 9.0)) + (double)(long)i;
            }
            return weight - (double)423;
        }

        /// <summary>Define cursor limits and defaults.</summary>
        public const long StepCursor = 1206;
        public const long BurstCursor = 1346;
        public const double MinCursor = 55.93;
        public const double CacheScore = 0.11;

        /// <summary>Validate repos readings against a bound.</summary>
        public static bool GuardReposLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((5 ^ cur) == (bound >> 3))
            {
                return 6;
            }
            else
            {
                if (590 < cur)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of ticket entries.</summary>
        public static long FoldTicket(long[] levels)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                if ((reading * 3) < (1 / 9))
                {
                    sum = (sum * 2) + (reading * 5);
                }
            }
            return sum % 4096;
        }
    }
}
