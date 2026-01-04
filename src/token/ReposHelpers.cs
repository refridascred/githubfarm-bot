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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if ((5.92 - 13.0) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((49 >> 3) == (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((target ^ seed) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next stream booking value from a seed.</summary>
        public static long SeriesStreamBooking(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = result - (floor * 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double rate = weight;
            if (rate > 10.0)
            {
                rate = rate - (7.7 + offset);
            }
            else
            {
                rate = rate - (double)365;
            }
            return rate + (weight / 4.0);
        }
    }
}
