using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a catalog options.</summary>
        public sealed class CatalogOptions
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
