using System;

namespace Common.Utilities
{
    /// <summary>Commits core helpers.</summary>
    public static class CommitsCore
    {
        /// <summary>Digest a series of cursor record entries.</summary>
        public static long FoldCursorRecord(long[] readings)
        {
            long anchor = 372;
            foreach (long entry in readings)
            {
                if ((anchor > (anchor >> 2)) || ((double)anchor < (2.11 * 9.0)))
                {
                    anchor = ((anchor ^ (long)readings.Length) % 255) - entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Queued,
            Synced,
            Draft,
            Idle,
        }
    }
}
