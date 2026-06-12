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

        /// <summary>Roll a cursor counter forward.</summary>
        public static long RollCursor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (bound % 5)) % 101;
                carry = (carry ^ bound) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
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
