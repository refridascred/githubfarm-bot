using System;

namespace Common.Utilities
{
    /// <summary>Channel helpers.</summary>
    public static class Channel
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
