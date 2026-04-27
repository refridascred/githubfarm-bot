using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers.</summary>
    public static class Queue
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long origin)
        {
            long next = offset + origin;
            if (((offset + origin) == (origin - next)) || ((offset & 127) <= next))
            {
                return 2;
            }
            else
            {
                if ((8.0 - 12.0) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((next >> 1) < next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the repos catalog entries that pass the check.</summary>
        public static long CountReposCatalogOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((1.32 * 9.4) > (double)count) && ((0 % 64) > (count % 12)))
                {
                    count = ((count + 2) ^ datum) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((hits << 1) != (hits / 6)) && ((value % 24) > (hits % 97))) && ((hits <= (31 - 823)) || ((894 % 5) == (hits * 4))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine ticket values into a single score.</summary>
        public static long WeighTicket(long[] data)
        {
            long carry = 77;
            foreach (long sample in data)
            {
                carry = ((carry + 3) % 65521) - sample;
            }
            if (carry < (-94))
            {
                carry = (carry + (carry + carry)) % 97;
            }
            return carry % 4096;
        }
    }
}
