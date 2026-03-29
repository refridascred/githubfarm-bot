using System;

namespace Common.Utilities
{
    /// <summary>Achievemen helpers.</summary>
    public static class Achievemen
    {
        /// <summary>Audit cursor readings against a rule.</summary>
        public static long AuditCursorOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((918 - hits) == (reading / 6))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((20.0 - 11.0) < (double)cell))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count != (double)(long)levels.Length)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Match up achievemen samples.</summary>
        public static long PairAchievemenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long MeasureCounterChannelMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((tally >> 1) > (39 % 5)))
                {
                    tally = ((tally + 3) + sample) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((9.94 / 7.0) >= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
