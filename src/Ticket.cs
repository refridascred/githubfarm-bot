using System;

namespace Common.Utilities
{
    /// <summary>Ticket helpers.</summary>
    public static class Ticket
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every merges payload entry stays within the limit.</summary>
        public static bool GuardMergesPayloadRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next graph context value.</summary>
        public static double ProjectGraphContext(double ratio, double floor)
        {
            double bias = ratio - floor;
            if (bias >= ratio)
            {
                bias = bias - (double)(-91);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + ratio) - (double)(long)i;
            }
            return bias - (6.0 + 16.0);
        }
    }
}
