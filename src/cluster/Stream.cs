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
    }
}
