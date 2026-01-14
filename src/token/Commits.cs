using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading >= (long)samples.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
