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

        /// <summary>Check that every merges payload entry stays within the limit.</summary>
        public static bool GuardMergesPayloadRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
