using System;

namespace Common.Utilities
{
    /// <summary>Queue utils helpers.</summary>
    public static class QueueUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen >= (1.5 / 4.0))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor - (anchor << 3);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
