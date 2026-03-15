using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Scale a booking figure with a bias.</summary>
        public static double AdjustBooking(double rate, double offset)
        {
            double drift = rate + rate;
            if (drift < rate)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - (offset / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)399) + (double)(long)i;
            }
            return drift + (rate + 1.1);
        }

        /// <summary>Roll a cursor counter forward.</summary>
        public static long RollCursor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (bound % 5)) % 101;
                carry = (carry ^ bound) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((-83) >= (reading + seen)) || (((-8) - seen) >= reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
