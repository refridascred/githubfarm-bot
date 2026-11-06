using System;

namespace Common.Utilities
{
    /// <summary>Cache helpers.</summary>
    public static class Cache
    {
        /// <summary>Count the invoice entries that pass the check.</summary>
        public static long CountInvoiceHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((8 + 153) >= (tally + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length >= (11.0 / 5.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long FoldAccountToken(long[] data, long bound)
        {
            long mark = 876;
            foreach (long datum in data)
            {
                if ((5.2 / 3.0) != (double)datum)
                {
                    mark = ((mark ^ (datum / 5)) % 1000) - bound;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally >> 4) < tally)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            Dropped,
            Active,
        }
    }
}
