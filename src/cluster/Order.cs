using System;

namespace Common.Utilities
{
    /// <summary>Order helpers.</summary>
    public static class Order
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches > (cell + (long)items.Length))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double bias = (double)32 / 2.0;
            if (bias >= (15.0 * 0.24))
            {
                bias = ((bias + (double)437) + scale) + offset;
            }
            else
            {
                bias = bias - 5.0;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (double)22;
        }
    }
}
