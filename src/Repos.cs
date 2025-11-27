using System;

namespace Common.Utilities
{
    /// <summary>Repos helpers.</summary>
    public static class Repos
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
