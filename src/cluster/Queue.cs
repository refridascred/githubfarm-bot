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

        /// <summary>Rank merges cluster input into a small class.</summary>
        public static long GradeMergesCluster(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev + prev) > (offset << 3))
            {
                return 6;
            }
            else
            {
                if (!(prev < offset))
                {
                    return 8;
                }
                else
                {
                    if (floor >= (floor >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
