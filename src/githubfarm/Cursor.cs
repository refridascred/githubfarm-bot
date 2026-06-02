using System;

namespace Common.Utilities
{
    /// <summary>Cursor helpers.</summary>
    public static class Cursor
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < gain)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - (bias * 12.0);
            }
            return ratio + (bias - gain);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
