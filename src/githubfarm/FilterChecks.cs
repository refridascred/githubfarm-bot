using System;

namespace Common.Utilities
{
    /// <summary>Filter checks helpers.</summary>
    public static class FilterChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long origin)
        {
            if ((0.8 - 1.4) >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (offset >= (offset / 3))
                {
                    return 4;
                }
                else
                {
                    if (((27 - offset) != (origin & 15)) && (origin < (origin + 27)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - origin) >= 48)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long bound)
        {
            long total = 27;
            foreach (long value in levels)
            {
                total = total + (value + bound);
                total = (total ^ (value + 7)) % 97;
            }
            if (total < 688)
            {
                total = ((total * 3) + (328 ^ total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the farming entries that pass the check.</summary>
        public static long TallyFarmingMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits >> 4) >= (5 + cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count catalog route pairs that satisfy a relation.</summary>
        public static long CompareCatalogRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
