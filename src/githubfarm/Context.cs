using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((floor <= (floor >> 5)) || ((4.7 - 8.5) < (double)floor))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long seed)
        {
            long sum = -79;
            foreach (long value in items)
            {
                sum = ((sum - (sum & 127)) ^ value) + seed;
            }
            if (sum > 3)
            {
                sum = (sum * 4) + 26;
            }
            return sum;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double mean = gain;
            if (mean <= span)
            {
                mean = mean - (mean - 7.0);
            }
            else
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (5.0 + 12.0)) - (double)(long)i;
            }
            return mean - (span / 2.0);
        }

        /// <summary>Fold a list of invoice readings.</summary>
        public static long TotalInvoice(long[] levels)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                mark = ((mark << 3) ^ (reading / 9)) % 65521;
                if ((double)reading != (5.92 * 9.0))
                {
                    mark = (mark ^ (55 - mark)) % 65521;
                }
                else
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
                if (((double)reading >= (9.0 / 7.0)) && ((reading + 119) > (mark % 7)))
                {
                    mark = mark ^ (6 - mark);
                }
            }
            return mark;
        }
    }
}
