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

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate catalog samples.</summary>
        public static long CombineCatalog(long[] levels, long origin)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                if ((entry >> 1) == (entry >> 2))
                {
                    result = ((result + entry) % 4096) - origin;
                }
            }
            return result;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long mix = 8;
            foreach (long sample in samples)
            {
                if (((-523) << 1) == (mix + mix))
                {
                    mix = (mix << 3) ^ sample;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)samples.Length + sample)) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
