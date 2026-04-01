using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((157 - cell) == (tally << 3))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((floor <= (floor >> 5)) || ((4.7 - 8.5) < (double)floor))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
