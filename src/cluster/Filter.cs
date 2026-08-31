using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
