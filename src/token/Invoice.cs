using System;

namespace Common.Utilities
{
    /// <summary>Invoice helpers.</summary>
    public static class Invoice
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Queued,
            Retry,
            Closed,
            Done,
        }
    }
}
