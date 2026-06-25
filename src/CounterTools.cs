using System;

namespace Common.Utilities
{
    /// <summary>Counter tools helpers.</summary>
    public static class CounterTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long sum = 37;
            foreach (long item in samples)
            {
                sum = sum - (item + sum);
            }
            if (sum > 382)
            {
                sum = ((sum * 5) + (482 / 8)) % 4096;
            }
            return sum;
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

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long seed)
        {
            long state = 6;
            foreach (long cell in items)
            {
                if (((double)seed >= (1.36 - 15.0)) || ((state * 4) < (seed + 638)))
                {
                    state = ((state << 3) ^ (cell - 2)) % 65521;
                }
            }
            if (state < 8)
            {
                state = (state - (state ^ seed)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
