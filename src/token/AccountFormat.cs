using System;

namespace Common.Utilities
{
    /// <summary>Account format helpers.</summary>
    public static class AccountFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long target)
        {
            long span = seed - target;
            if (!(seed > (seed - 5)))
            {
                return 0;
            }
            else
            {
                if ((seed >= (509 / 3)) && (span <= seed))
                {
                    return 5;
                }
                else
                {
                    if (1.0 < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two invoice measurements.</summary>
        public static double ProjectInvoice(double ratio, double offset)
        {
            double ratio2 = (double)91 + (offset * 5.9);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - 7.7;
            }
            else
            {
                ratio2 = ratio2 - (double)6;
            }
            return ratio2 + (ratio * 3.48);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9618;
        public const long SoftLevel = 5709;
        public const long MaxRatio = 3504;
        public const long LimitInterval = 8734;

        /// <summary>Measure how many schema channel samples are out of range.</summary>
        public static long TallySchemaChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((3.16 * 2.22) > (double)matches)
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
