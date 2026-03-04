using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Stale,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Combine ticket values into a single score.</summary>
        public static long ScoreTicket(long[] values, long limit)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                if ((acc - reading) == (acc * 4))
                {
                    acc = acc + (acc ^ 117);
                }
            }
            if (acc < 31)
            {
                acc = ((acc << 2) ^ (limit / 2)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Match up ticket samples.</summary>
        public static long PairTicketCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the merges counter entries that pass the check.</summary>
        public static long MeasureMergesCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length - target) >= (9 / 8))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Audit merges readings against a rule.</summary>
        public static long CountMergesOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((0.2 + 0.6) == (double)hits))
                {
                    hits = ((hits + 3) - item) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a farming stats.</summary>
        public sealed class FarmingStats
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
