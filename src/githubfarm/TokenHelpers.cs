using System;

namespace Common.Utilities
{
    /// <summary>Token helpers helpers.</summary>
    public static class TokenHelpers
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((result << 1) < ((long)i & 7)))
                {
                    result = result - (result & 15);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 58.99;
        public const long BaseRatio = 8800;
        public const string SoftInterval = "fallback-1";
    }
}
