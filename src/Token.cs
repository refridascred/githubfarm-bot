using System;

namespace Common.Utilities
{
    /// <summary>Token helpers.</summary>
    public static class Token
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                if (!(step >= (6 / 4)))
                {
                    total = total ^ ((long)i + 10);
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
