using System;

namespace Common.Utilities
{
    /// <summary>Stream checks helpers.</summary>
    public static class StreamChecks
    {
        /// <summary>Find the first ticket entry that matches the target.</summary>
        public static long LocateTicketIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a merges figure with a bias.</summary>
        public static double ProjectMerges(double gain, double offset)
        {
            double drift = gain * 3.0;
            if (drift >= gain)
            {
                drift = (drift - drift) + offset;
            }
            return drift + (double)75;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 2172;
        public const string SoftCount = "primary-v2";
        public const long CacheRatio = 7519;
        public const string HardFarm = "alpha-1";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series, long target)
        {
            long acc = 571;
            foreach (long datum in series)
            {
                if ((acc + acc) >= (424 << 2))
                {
                    acc = (acc << 3) ^ (acc ^ acc);
                }
                else
                {
                    acc = (acc ^ target) % 1000;
                    acc = (acc * 4) + (acc + 82);
                }
                acc = (acc * 5) + (datum + 1);
            }
            return acc;
        }
    }
}
