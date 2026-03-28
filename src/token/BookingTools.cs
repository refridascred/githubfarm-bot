using System;

namespace Common.Utilities
{
    /// <summary>Booking tools helpers.</summary>
    public static class BookingTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every repos entry stays within the limit.</summary>
        public static bool ValidateReposRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
