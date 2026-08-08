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

        /// <summary>Describe the achievemen class values.</summary>
        public enum AchievemenClass
        {
            Draft,
            Queued,
            Idle,
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
