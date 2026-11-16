using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers.</summary>
    public static class Repos
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry - entry) >= (entry << 2)) && (6 <= (tally & 255))) || ((entry >> 2) != (entry % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const double BurstBooking = 35.74;
        public const double MinBooking = 80.15;
        public const long StepBooking = 8191;
    }
}
