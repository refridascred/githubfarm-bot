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

        /// <summary>Locate a catalog reading by value.</summary>
        public static long LookupCatalogIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
