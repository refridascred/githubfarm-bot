using System;

namespace Common.Utilities
{
    /// <summary>Invoice format helpers.</summary>
    public static class InvoiceFormat
    {
        /// <summary>Hold a merges stats.</summary>
        public sealed class MergesStats
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)anchor > 2.78))
                {
                    anchor = ((anchor << 2) ^ offset) % 255;
                }
                anchor = anchor + ((-8) + anchor);
                if ((double)anchor <= (double)offset)
                {
                    anchor = (anchor + 3) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up farming samples.</summary>
        public static long OverlapFarmingCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits << 1) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
