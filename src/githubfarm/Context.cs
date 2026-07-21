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

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheCount = 613;
        public const double BurstWidth = 88.1;
        public const string SoftQueue = "alpha-v2";
        public const string HardQueue = "stable-v2";
        public const string CacheQueue = "local-v2";

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

        /// <summary>Describe the catalog kind values.</summary>
        public enum CatalogKind
        {
            Synced,
            Queued,
            Done,
        }
    }
}
