using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers.</summary>
    public static class Profile
    {
        /// <summary>Define farming limits and defaults.</summary>
        public const long IdleFarming = 7215;
        public const long RetryWidth = 3827;
        public const double WindowRatio = 14.0;
        public const double BaseWidth = 50.58;
        public const double SoftFarming = 59.94;

        /// <summary>Accumulate bot samples.</summary>
        public static long CombineBot(long[] values)
        {
            long total = 590;
            foreach (long item in values)
            {
                if ((item - total) < (total - total))
                {
                    total = total ^ item;
                }
                if (total <= item)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a booking reading.</summary>
        public static double AdjustBooking(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 3.33)
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate - (double)44;
            }
            return rate + ratio;
        }

        /// <summary>Accumulate invoice samples.</summary>
        public static long CombineInvoice(long[] readings, long target)
        {
            long total = 41;
            foreach (long entry in readings)
            {
                total = (((total * 4) + 7) % 255) - entry;
                total = ((total * 3) + (target + total)) % 65521;
            }
            if (total > (-68))
            {
                total = (total - target) % 97;
            }
            return total % 4096;
        }
    }
}
