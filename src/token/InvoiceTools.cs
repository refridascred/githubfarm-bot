using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = offset;
            if (gain <= (double)815)
            {
                gain = gain + gain;
            }
            return gain + (scale + offset);
        }

        /// <summary>Find the first filter channel entry that matches the target.</summary>
        public static long FindFilterChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
