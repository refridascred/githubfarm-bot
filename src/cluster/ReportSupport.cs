using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Count booking pairs that satisfy a relation.</summary>
        public static long PairBookingCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long result = 266;
            foreach (long cell in samples)
            {
                result = ((result * 5) + result) ^ cell;
            }
            return result % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict-1";
        public const long RetryCommits = 3765;
        public const long HardCommits = 9200;
        public const long MaxBudget = 8370;
        public const long BatchRatio = 8692;

        /// <summary>Validate command record readings against a bound.</summary>
        public static bool CheckCommandRecordBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 84.48;
        public const string DefaultScore = "legacy-v2";
        public const string BurstToken = "local-1";
    }
}
