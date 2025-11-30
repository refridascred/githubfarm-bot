using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Hold a repos header.</summary>
        public sealed class ReposHeader
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
