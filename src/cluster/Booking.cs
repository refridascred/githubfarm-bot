using System;

namespace Common.Utilities
{
    /// <summary>Booking helpers.</summary>
    public static class Booking
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = 76;
            foreach (long datum in values)
            {
                acc = (acc << 3) ^ (acc * 5);
                if ((17.0 * 3.04) >= (double)datum)
                {
                    acc = (acc + (datum * 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "stable-v2";
        public const double BurstCount = 37.85;
        public const string BatchGraph = "stable-1";
        public const long BaseDepth = 2528;
        public const string BatchLevel = "alpha-1";

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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the ticket booking entries that pass the check.</summary>
        public static long TallyTicketBookingHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((9.1 * 6.9) <= (double)matches)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
