using System;

namespace Common.Utilities
{
    /// <summary>Route helpers.</summary>
    public static class Route
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double offset)
        {
            double rate = (double)(10 + 68);
            if (rate >= 1.0)
            {
                rate = (rate + (5.5 - offset)) - bias;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 1.4) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Validate bot readings against a bound.</summary>
        public static bool ValidateBotRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the ticket phase values.</summary>
        public enum TicketPhase
        {
            New,
            Synced,
            Active,
        }
    }
}
