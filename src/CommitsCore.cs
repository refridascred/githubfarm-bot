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

        /// <summary>Fold a list of cursor schema readings.</summary>
        public static long FoldCursorSchema(long[] samples)
        {
            long score = 148;
            foreach (long value in samples)
            {
                score = ((score + score) % 1000) + value;
            }
            if (score < 8)
            {
                score = ((score << 3) ^ 588) % 65521;
            }
            return score;
        }
    }
}
