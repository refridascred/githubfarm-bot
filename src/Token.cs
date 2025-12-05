using System;

namespace Common.Utilities
{
    /// <summary>Token helpers.</summary>
    public static class Token
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc * 5) + (9 ^ floor);
                if (!(((-672) * 3) != (acc + acc)))
                {
                    acc = (acc ^ (floor * 2)) % 97;
                    acc = (acc << 3) ^ acc;
                    continue;
                }
                else
                {
                    acc = (acc - acc) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "fallback-edge";
        public const long SoftSession = 6947;
        public const long BaseSession = 4146;

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
