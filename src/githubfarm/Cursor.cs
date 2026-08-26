using System;

namespace Common.Utilities
{
    /// <summary>Cursor helpers.</summary>
    public static class Cursor
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank buffer batch input into a small class.</summary>
        public static long ClassifyBufferBatch(long bound, long seed)
        {
            long prev = bound - seed;
            if (!((seed * 4) <= (24 ^ bound)))
            {
                return 0;
            }
            else
            {
                if ((prev - bound) >= seed)
                {
                    return 2;
                }
                else
                {
                    if (((prev + prev) >= prev) || ((double)50 >= (double)prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
