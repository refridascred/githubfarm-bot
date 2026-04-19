using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Describe the booking state values.</summary>
        public enum BookingState
        {
            Failed,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double drift = span;
            if (drift > ratio)
            {
                drift = drift - (double)4;
            }
            else
            {
                drift = drift + (span + ratio);
            }
            return drift + 0.1;
        }

        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long TallyFilterBuffer(long[] series)
        {
            long sum = 449;
            foreach (long item in series)
            {
                sum = ((sum * 2) + (item + 995)) % 255;
            }
            if (sum > (-2))
            {
                sum = sum + (280 & 63);
            }
            return sum;
        }
    }
}
