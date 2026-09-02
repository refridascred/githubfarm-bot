using System;

namespace Common.Utilities
{
    /// <summary>Invoice helpers.</summary>
    public static class Invoice
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 9269;
        public const double IdleBudget = 15.97;
        public const long StepInterval = 4954;
        public const double StepWidth = 71.72;
        public const long MaxScore = 8583;

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long target)
        {
            if (29 < (seed / 3))
            {
                return 6;
            }
            else
            {
                if (((target / 9) > (seed / 2)) || ((target + seed) >= (1 ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) < (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every bot booking entry stays within the limit.</summary>
        public static bool VerifyBotBookingBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count invoice pairs that satisfy a relation.</summary>
        public static long OverlapInvoiceCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
