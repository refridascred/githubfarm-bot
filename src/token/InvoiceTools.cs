using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = offset;
            if (gain <= (double)815)
            {
                gain = gain + gain;
            }
            return gain + (scale + offset);
        }

        /// <summary>Hold a achievemen options.</summary>
        public sealed class AchievemenOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue route counter forward.</summary>
        public static long IterateQueueRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the merges entries that pass the check.</summary>
        public static long CountMergesGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count % 12) < (543 - count))
                {
                    count = ((count + 1) ^ reading) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
