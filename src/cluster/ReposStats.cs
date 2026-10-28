using System;

namespace Common.Utilities
{
    /// <summary>Repos stats helpers.</summary>
    public static class ReposStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((620 + 30) >= (hits + item)) && ((6 << 2) > (hits + item)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define invoice limits and defaults.</summary>
        public const long SoftInvoice = 9842;
        public const string BatchInvoice = "primary-v2";
        public const long HardWidth = 1785;
        public const long MinRatio = 1482;
        public const long MinTimeout = 867;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftInterval = 4565;
        public const string BatchSize = "open-v2";
        public const string MaxBudget = "legacy-1";
        public const long BatchFactor = 5777;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Dropped,
            Paused,
            Queued,
            Active,
        }
    }
}
