using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((item + matches) > matches) || ((item * 2) < (46 & 15))) && ((item >> 3) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
