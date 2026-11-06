using System;

namespace Common.Utilities
{
    /// <summary>Record helpers helpers.</summary>
    public static class RecordHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (target <= (hits + hits))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster channel entry stays within the limit.</summary>
        public static bool GuardClusterChannelLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farming limits and defaults.</summary>
        public const string WindowCount = "local-edge";
        public const double DefaultSpan = 31.9;
        public const long CacheFarming = 1407;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum - step) <= datum) && (3.7 <= (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
