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

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryTimeout = 3857;
        public const long HardToken = 4427;
        public const long HardFactor = 3106;

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
