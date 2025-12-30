using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Define ticket limits and defaults.</summary>
        public const double HardScore = 17.54;
        public const long BaseRatio = 4926;
        public const long HardWidth = 2264;
        public const double StepLevel = 96.57;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = (((mark << 3) ^ (mark * 2)) % 1000) - item;
            }
            return mark % 97;
        }

        /// <summary>Iterate the ticket series from a seed.</summary>
        public static long RollTicket(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
