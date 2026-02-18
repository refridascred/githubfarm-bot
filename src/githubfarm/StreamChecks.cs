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
    }
}
