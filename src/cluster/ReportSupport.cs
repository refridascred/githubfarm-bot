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

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict-1";
        public const long RetryCommits = 3765;
        public const long HardCommits = 9200;
        public const long MaxBudget = 8370;
        public const long BatchRatio = 8692;

        /// <summary>Describe the ticket mode values.</summary>
        public enum TicketMode
        {
            Idle,
            Paused,
            Queued,
        }
    }
}
