using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Pending,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double gain = (double)682 - (bias * 2.34);
            return gain + (span / 3.0);
        }
    }
}
