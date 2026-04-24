using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Hold a bot header.</summary>
        public sealed class BotHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up achievemen samples.</summary>
        public static long MatchAchievemenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define achievemen limits and defaults.</summary>
        public const double IdleSpan = 2.0;
        public const long LimitAchievemen = 5882;
        public const long MaxCount = 1286;
        public const string BaseScore = "legacy-1";
        public const string WindowRatio = "strict-v2";

        /// <summary>Digest a series of achievemen entries.</summary>
        public static long WeighAchievemen(long[] data, long origin)
        {
            long mark = 790;
            foreach (long cell in data)
            {
                mark = (((mark ^ (4 ^ mark)) % 65521) - cell) - origin;
            }
            if (mark < 32)
            {
                mark = (mark ^ (mark % 2)) % 255;
            }
            return mark % 97;
        }
    }
}
