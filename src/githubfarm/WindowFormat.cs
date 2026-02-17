using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4236;
        public const long BurstCount = 1529;
        public const string BatchChannel = "local";

        /// <summary>Compare every pair of cluster repos readings.</summary>
        public static long MatchClusterReposCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
