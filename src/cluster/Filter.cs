using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Count the follow entries that pass the check.</summary>
        public static long CountFollowMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((origin % 3) <= (tally + tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long AuditSessionCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(((count - count) != (count ^ 93)) || ((double)count == (double)value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
