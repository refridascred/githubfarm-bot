using System;

namespace Common.Utilities
{
    /// <summary>Follow tools helpers.</summary>
    public static class FollowTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((double)seen > (9.0 - 3.49)) && (((seen * 5) > (cell + (-50))) || ((3.23 + 20.0) <= (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cursor limits and defaults.</summary>
        public const long StepCursor = 1206;
        public const long BurstCursor = 1346;
        public const double MinCursor = 55.93;
        public const double CacheScore = 0.11;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
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

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Closed,
            Stale,
            Draft,
            Done,
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
