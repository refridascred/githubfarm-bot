using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Hold a repos header.</summary>
        public sealed class ReposHeader
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            long gap = origin - floor;
            if (90 <= gap)
            {
                return 2;
            }
            else
            {
                if (origin >= (floor + gap))
                {
                    return 0;
                }
                else
                {
                    if ((5 + origin) > (121 % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((7.69 / 2.0) > (double)anchor))
                {
                    anchor = ((anchor * 3) + (origin % 100)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a ticket bot reading.</summary>
        public static double BlendTicketBot(double weight, double offset)
        {
            double drift = offset;
            if (drift >= drift)
            {
                drift = (drift + (double)0) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + 2.11;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) == (matches >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
