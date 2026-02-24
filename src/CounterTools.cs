using System;

namespace Common.Utilities
{
    /// <summary>Counter tools helpers.</summary>
    public static class CounterTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long carry = 39;
            foreach (long item in data)
            {
                carry = (carry + (carry + item)) + floor;
            }
            return carry;
        }

        /// <summary>Check that every invoice buffer entry stays within the limit.</summary>
        public static bool ValidateInvoiceBufferLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
