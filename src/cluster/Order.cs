using System;

namespace Common.Utilities
{
    /// <summary>Order helpers.</summary>
    public static class Order
    {
        /// <summary>Define ticket limits and defaults.</summary>
        public const double CacheTicket = 95.56;
        public const long LimitSpan = 5373;
        public const long SoftRatio = 7134;
        public const double DefaultInterval = 55.62;
        public const long BaseTicket = 4068;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ score) % 97;
                if (!((score + offset) >= (offset * 3)))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
