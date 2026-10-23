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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (7 >= (tally ^ cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
