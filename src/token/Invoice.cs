using System;

namespace Common.Utilities
{
    /// <summary>Invoice helpers.</summary>
    public static class Invoice
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Queued,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
