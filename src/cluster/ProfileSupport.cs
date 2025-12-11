using System;

namespace Common.Utilities
{
    /// <summary>Profile support helpers.</summary>
    public static class ProfileSupport
    {
        /// <summary>Digest a series of repos entries.</summary>
        public static long TotalRepos(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                state = ((state ^ ((-554) + (-673))) % 65521) ^ reading;
            }
            return state;
        }
    }
}
