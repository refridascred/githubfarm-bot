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
    }
}
