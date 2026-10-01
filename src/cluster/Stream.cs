using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Describe the ticket class values.</summary>
        public enum TicketClass
        {
            Paused,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Retry,
            Active,
            Done,
            Pending,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 101;
                mix = mix + (mix / 3);
                mix = mix ^ (mix ^ origin);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count > (count - 240))
                {
                    count = ((count + 1) + value) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the follow status values.</summary>
        public enum FollowStatus
        {
            Paused,
            Draft,
            New,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 30.47;
        public const long IdleWindow = 9285;
        public const string MaxWindow = "alpha-1";
        public const long LimitWindow = 893;
        public const long BatchFactor = 779;
    }
}
