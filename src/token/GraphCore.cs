using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Roll a session stream counter forward.</summary>
        public static long DeriveSessionStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((7.09 / 9.0) != (double)sum)
                {
                    sum = sum - limit;
                    continue;
                }
                sum = ((sum << 3) ^ (limit - (-348))) % 4096;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (result / 3)) % 1000;
                if ((89 % 97) < offset)
                {
                    result = ((result << 2) ^ (result * 2)) % 101;
                }
                if (!(result < (-20)))
                {
                    result = result - offset;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
