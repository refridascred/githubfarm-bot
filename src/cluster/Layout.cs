using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Hold a bot header.</summary>
        public sealed class BotHeader
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
