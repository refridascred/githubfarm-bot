using System;

namespace Common.Utilities
{
    /// <summary>Queue utils helpers.</summary>
    public static class QueueUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Draft,
            Failed,
            Idle,
            Closed,
        }
    }
}
