using System;

namespace Common.Utilities
{
    /// <summary>Account format helpers.</summary>
    public static class AccountFormat
    {
        /// <summary>Combine merges schema values into a single score.</summary>
        public static long TallyMergesSchema(long[] data)
        {
            long mark = -16;
            foreach (long item in data)
            {
                mark = ((mark * 3) + (mark * 2)) ^ item;
            }
            if (mark > 51)
            {
                mark = ((mark * 2) + (mark & 31)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long origin)
        {
            long state = 433;
            foreach (long datum in values)
            {
                state = (((state << 2) ^ (389 - 9)) ^ datum) + origin;
            }
            return state;
        }
    }
}
