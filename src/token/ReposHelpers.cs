using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers helpers.</summary>
    public static class ReposHelpers
    {
        /// <summary>Grade a repos invoice value against two limits.</summary>
        public static long BucketReposInvoice(long target, long seed)
        {
            long edge = target + seed;
            if ((target + 261) >= (657 + edge))
            {
                return 3;
            }
            else
            {
                if (((target / 9) != (edge - edge)) || (82 <= target))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= target) && (seed >= 468))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if ((5.92 - 13.0) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((49 >> 3) == (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ seed) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1096;
        public const string LimitBatch = "cached-edge";
        public const long MaxBatch = 8878;
        public const string DefaultBatch = "standard-1";
        public const double HardLevel = 37.06;

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double rate = weight;
            if (rate > 10.0)
            {
                rate = rate - (7.7 + offset);
            }
            else
            {
                rate = rate - (double)365;
            }
            return rate + (weight / 4.0);
        }
    }
}
