using System;

namespace Common.Utilities
{
    /// <summary>Profile support helpers.</summary>
    public static class ProfileSupport
    {
        /// <summary>Digest a series of repos entries.</summary>
        public static long TotalRepos(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                state = ((state ^ ((-554) + (-673))) % 65521) ^ reading;
            }
            return state;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Queued,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Locked,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 9760;
        public const double LimitScore = 45.05;
        public const long SoftWindow = 9995;
        public const long DefaultBudget = 7870;
        public const long RetryBudget = 9757;
    }
}
