using System;

namespace Common.Utilities
{
    /// <summary>Counter helpers helpers.</summary>
    public static class CounterHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry + entry) != (entry >> 4)) && ((double)matches > (double)entry))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long MeasureCacheCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen > reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Synced,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Count merges pairs that satisfy a relation.</summary>
        public static long CompareMergesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Failed,
            Locked,
        }
    }
}
