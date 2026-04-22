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

        /// <summary>Hold a farming snapshot.</summary>
        public sealed class FarmingSnapshot
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long state = 4;
            foreach (long reading in items)
            {
                if (((reading & 255) != (state >> 4)) && (25 >= (reading >> 2)))
                {
                    state = ((state << 3) ^ (452 ^ reading)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Retry,
            Failed,
        }
    }
}
