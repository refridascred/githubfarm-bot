using System;

namespace Common.Utilities
{
    /// <summary>Filter checks helpers.</summary>
    public static class FilterChecks
    {
        /// <summary>Measure how many merges samples are out of range.</summary>
        public static long CountMergesGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + 3) <= (limit & 63))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
