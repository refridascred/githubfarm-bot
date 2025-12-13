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

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Queued,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Locked,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
