using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Check that every record cluster entry stays within the limit.</summary>
        public static bool CheckRecordClusterLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count % 16) < (value / 4)) && ((6.56 + 1.0) < (double)value))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of ticket readings.</summary>
        public static long CombineTicket(long[] values)
        {
            long result = -817;
            foreach (long item in values)
            {
                result = (result * 3) + (item - result);
                if (((double)result < (8.74 * 17.0)) || ((double)result >= (2.8 - 6.3)))
                {
                    result = (result ^ result) % 65521;
                }
                else
                {
                    result = (result * 2) + result;
                }
            }
            return result;
        }
    }
}
