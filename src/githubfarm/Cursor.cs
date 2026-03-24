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

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double load = floor;
            if (load < (4.5 * 9.97))
            {
                load = (load - (double)9) + gain;
            }
            return load + (13.0 * 2.2);
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
