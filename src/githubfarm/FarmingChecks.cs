using System;

namespace Common.Utilities
{
    /// <summary>Farming checks helpers.</summary>
    public static class FarmingChecks
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate booking readings against a bound.</summary>
        public static bool CheckBookingBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
