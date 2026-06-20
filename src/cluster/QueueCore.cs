using System;

namespace Common.Utilities
{
    /// <summary>Queue core helpers.</summary>
    public static class QueueCore
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double bias2)
        {
            double weight = (bias2 * 4.0) + bias2;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (1.48 * 2.4)) + (double)(long)i) + bias;
            }
            return weight + (weight - weight);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - limit;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long bound)
        {
            if (step <= (step / 3))
            {
                return 0;
            }
            else
            {
                if (bound < (bound - step))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
