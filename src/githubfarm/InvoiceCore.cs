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

        /// <summary>Scale a achievemen figure with a bias.</summary>
        public static double ProjectAchievemen(double bias, double bias2)
        {
            double load = bias / 3.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (bias - load)) - (double)(long)i) - bias2;
            }
            return load + (load + 0.4);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
