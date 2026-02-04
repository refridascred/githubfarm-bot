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
    }
}
