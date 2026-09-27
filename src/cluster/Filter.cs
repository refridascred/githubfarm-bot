using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Count the follow entries that pass the check.</summary>
        public static long CountFollowMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((origin % 3) <= (tally + tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
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
