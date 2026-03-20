using System;

namespace Common.Utilities
{
    /// <summary>Filter helpers.</summary>
    public static class Filter
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Queued,
            Done,
            Idle,
        }
    }
}
