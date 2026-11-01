using System;

namespace Common.Utilities
{
    /// <summary>Booking tools helpers.</summary>
    public static class BookingTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            New,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
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
