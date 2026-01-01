using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Describe the booking state values.</summary>
        public enum BookingState
        {
            Failed,
            Closed,
            Queued,
            Done,
        }
    }
}
