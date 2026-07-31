using System;

namespace Common.Utilities
{
    /// <summary>Token helpers.</summary>
    public static class Token
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long seed)
        {
            if ((920 + seed) == (seed << 1))
            {
                return 4;
            }
            else
            {
                if ((target >> 3) != (target + target))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed == (13.0 * 4.25))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target == (1.68 / 8.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3813;
        public const long CacheProfile = 6458;
        public const double MaxWidth = 83.1;

        /// <summary>Combine catalog values into a single score.</summary>
        public static long TotalCatalog(long[] readings)
        {
            long total = 58;
            foreach (long value in readings)
            {
                if (((double)total != (14.0 - 7.0)) && ((6.46 * 6.3) > (double)total))
                {
                    total = ((total + 683) % 255) ^ value;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the metric ticket entries that pass the check.</summary>
        public static long AuditMetricTicketMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 255) >= (count - count))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Score { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
