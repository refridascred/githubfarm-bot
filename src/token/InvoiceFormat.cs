using System;

namespace Common.Utilities
{
    /// <summary>Invoice format helpers.</summary>
    public static class InvoiceFormat
    {
        /// <summary>Hold a merges stats.</summary>
        public sealed class MergesStats
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8337;
        public const double CacheFactor = 86.9;
        public const long SoftContext = 999;
        public const string LimitCount = "staging-edge";

        /// <summary>Match up farming samples.</summary>
        public static long OverlapFarmingCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long MeasureReportCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen >= (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
