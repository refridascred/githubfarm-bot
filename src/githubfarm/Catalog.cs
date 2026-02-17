using System;

namespace Common.Utilities
{
    /// <summary>Catalog helpers.</summary>
    public static class Catalog
    {
        /// <summary>Locate a order repos reading by value.</summary>
        public static long FindOrderReposIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 9809;
        public const long CacheSize = 4161;
        public const long MinBatch = 9825;
        public const long BaseTimeout = 7268;
        public const long HardBatch = 1353;
    }
}
