using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Draft,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long carry = 4;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry ^ (carry / 6)) % 65521) ^ (long)i) - datum;
                }
                carry = carry - (carry / 2);
            }
            return carry % 65521;
        }

        /// <summary>Count the follow entries that pass the check.</summary>
        public static long CountFollowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry - hits) >= (hits - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream cluster value.</summary>
        public static double ScaleStreamCluster(double rate, double span)
        {
            double bias = 4.9;
            if (bias <= (double)2)
            {
                bias = (bias - bias) - rate;
            }
            else
            {
                bias = bias + 10.0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (span / 7.0);
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
