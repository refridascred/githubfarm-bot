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
    }
}
