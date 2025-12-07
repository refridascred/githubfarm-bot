using System;

namespace Common.Utilities
{
    /// <summary>Ticket helpers.</summary>
    public static class Ticket
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
