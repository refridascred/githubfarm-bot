using System;

namespace Common.Utilities
{
    /// <summary>Profile support helpers.</summary>
    public static class ProfileSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long AuditBatchCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - entry) >= (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Rank repos input into a small class.</summary>
        public static long BucketRepos(long limit, long bound)
        {
            if (!(limit < (bound % 97)))
            {
                return 0;
            }
            else
            {
                if (!((bound + limit) > (bound << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 16) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit + 71) > bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 9760;
        public const double LimitScore = 45.05;
        public const long SoftWindow = 9995;
        public const long DefaultBudget = 7870;
        public const long RetryBudget = 9757;
    }
}
