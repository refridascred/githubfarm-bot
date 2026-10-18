using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
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

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 84.48;
        public const string DefaultScore = "legacy-v2";
        public const string BurstToken = "local-1";
    }
}
