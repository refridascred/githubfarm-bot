using System;

namespace Common.Utilities
{
    /// <summary>Stream checks helpers.</summary>
    public static class StreamChecks
    {
        /// <summary>Find the first ticket entry that matches the target.</summary>
        public static long LocateTicketIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
