using System;

namespace Common.Utilities
{
    /// <summary>Counter tools helpers.</summary>
    public static class CounterTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long carry = 39;
            foreach (long item in data)
            {
                carry = (carry + (carry + item)) + floor;
            }
            return carry;
        }
    }
}
