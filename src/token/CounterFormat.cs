using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a invoice counter reading.</summary>
        public static double BlendInvoiceCounter(double bias, double offset)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = (drift - 20.0) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 2.74) - (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Find the first commits account entry that matches the target.</summary>
        public static long LookupCommitsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the merges counter entries that pass the check.</summary>
        public static long MeasureMergesCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length - target) >= (9 / 8))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound - 982) < (total >> 4))
                {
                    total = (total + bound) % 65521;
                }
                total = (total + bound) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
