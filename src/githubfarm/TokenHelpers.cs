using System;

namespace Common.Utilities
{
    /// <summary>Token helpers helpers.</summary>
    public static class TokenHelpers
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((result << 1) < ((long)i & 7)))
                {
                    result = result - (result & 15);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
