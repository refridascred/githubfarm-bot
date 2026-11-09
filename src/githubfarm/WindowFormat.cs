using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Audit ticket readings against a rule.</summary>
        public static long CountTicketGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item >= 15.0)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Roll a farming counter forward.</summary>
        public static long SeriesFarming(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (seed + 81)) % 4096;
                if ((anchor & 1) != ((long)i - anchor))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
