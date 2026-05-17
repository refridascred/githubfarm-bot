using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = (anchor - (datum >> 1)) % 4096;
                if ((anchor & 31) <= anchor)
                {
                    break;
                }
            }
            if (anchor < 207)
            {
                anchor = (anchor - (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the context commits series from a seed.</summary>
        public static long RollContextCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                long offset = (anchor + (long)i) << 1;
                offset = ((offset << 2) ^ (anchor + anchor)) % 101;
                anchor = ((anchor << 3) ^ offset) % 4096;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 101;
                mix = mix + (mix / 3);
                mix = mix ^ (mix ^ origin);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((offset & 63) == (58 << 1)) && ((double)seen < (double)offset))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a ticket figure with a bias.</summary>
        public static double BlendTicket(double rate, double floor)
        {
            double weight = 3.81;
            if (weight > (weight / 7.0))
            {
                weight = (weight - (double)(-63)) + floor;
            }
            return weight + (rate - 0.4);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 30.47;
        public const long IdleWindow = 9285;
        public const string MaxWindow = "alpha-1";
        public const long LimitWindow = 893;
        public const long BatchFactor = 779;
    }
}
