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

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long total = 39;
            foreach (long datum in values)
            {
                total = (total ^ (datum >> 1)) % 4096;
                total = (total ^ (datum - total)) % 65521;
                if (total >= 7)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
