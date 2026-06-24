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

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSpan = 43.4;
        public const long MinLevel = 5366;
        public const long RetryLevel = 9178;
        public const string RetryFactor = "legacy-1";

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
