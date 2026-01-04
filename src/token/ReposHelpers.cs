using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers helpers.</summary>
    public static class ReposHelpers
    {
        /// <summary>Grade a repos invoice value against two limits.</summary>
        public static long BucketReposInvoice(long target, long seed)
        {
            long edge = target + seed;
            if ((target + 261) >= (657 + edge))
            {
                return 3;
            }
            else
            {
                if (((target / 9) != (edge - edge)) || (82 <= target))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= target) && (seed >= 468))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first booking githubfarm entry that matches the target.</summary>
        public static long FindBookingGithubfarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
