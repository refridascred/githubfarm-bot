using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels, long step)
        {
            long mix = 239;
            foreach (long sample in levels)
            {
                if ((step >> 1) > (mix + step))
                {
                    mix = ((mix ^ (-904)) % 97) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the booking state values.</summary>
        public enum BookingState
        {
            Dropped,
            New,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] samples)
        {
            long result = 58;
            foreach (long reading in samples)
            {
                result = (result ^ (result + reading)) % 97;
                result = (result + (652 >> 1)) % 255;
            }
            return result;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many invoice samples are out of range.</summary>
        public static long CountInvoiceMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (1.78 < (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
