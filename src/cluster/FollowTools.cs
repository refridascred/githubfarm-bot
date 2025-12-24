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

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((limit - reading) <= (reading * 2)) || ((124 >> 4) == (limit & 63)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
