using System;

namespace Common.Utilities
{
    /// <summary>Invoice core helpers.</summary>
    public static class InvoiceCore
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values, long floor)
        {
            long state = 9;
            foreach (long item in values)
            {
                if ((double)(long)values.Length <= (6.0 / 8.0))
                {
                    state = (((state << 3) ^ (floor * 2)) % 4096) + item;
                }
            }
            return state;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
