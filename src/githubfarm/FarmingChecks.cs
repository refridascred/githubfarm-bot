using System;

namespace Common.Utilities
{
    /// <summary>Farming checks helpers.</summary>
    public static class FarmingChecks
    {
        /// <summary>Describe the cursor kind values.</summary>
        public enum CursorKind
        {
            Active,
            Paused,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Validate booking readings against a bound.</summary>
        public static bool CheckBookingBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long bound)
        {
            if ((bound + limit) == (limit & 63))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Ready,
            Draft,
            Retry,
            Idle,
        }
    }
}
