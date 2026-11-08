using System;

namespace Common.Utilities
{
    /// <summary>Catalog helpers.</summary>
    public static class Catalog
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)1 > (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long floor)
        {
            long state = 288;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (state ^ (62 ^ value)) + (long)i;
                }
                if (value >= (value << 3))
                {
                    state = ((state * 3) + (state - floor)) % 4096;
                }
            }
            if (state < (-290))
            {
                state = (state + (floor % 64)) % 97;
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits != (double)origin)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < (tally & 31))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
