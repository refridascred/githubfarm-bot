using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers helpers.</summary>
    public static class ReposHelpers
    {
        /// <summary>Define follow limits and defaults.</summary>
        public const long MaxFollow = 595;
        public const long StepFollow = 4313;
        public const string HardCount = "alpha-v2";

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
