using System;

namespace Common.Utilities
{
    /// <summary>Booking helpers.</summary>
    public static class Booking
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            New,
            Retry,
            Locked,
        }

        /// <summary>Check that every cluster farm entry stays within the limit.</summary>
        public static bool GuardClusterFarmRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((offset / 9) >= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
