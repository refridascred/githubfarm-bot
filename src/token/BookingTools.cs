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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
