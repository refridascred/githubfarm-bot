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

        /// <summary>Roll a repos invoice counter forward.</summary>
        public static long StepReposInvoice(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ 62;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
