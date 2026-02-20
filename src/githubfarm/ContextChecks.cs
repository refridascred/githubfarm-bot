using System;

namespace Common.Utilities
{
    /// <summary>Context checks helpers.</summary>
    public static class ContextChecks
    {
        /// <summary>Find the first merges channel entry that matches the target.</summary>
        public static long LocateMergesChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
