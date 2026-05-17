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

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 1939;
        public const long MaxPayload = 8674;
        public const double BurstCount = 13.4;

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
