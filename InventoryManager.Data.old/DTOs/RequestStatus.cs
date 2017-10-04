using System;

namespace InventoryManager.Data.DTOs
{
    public class RequestStatus
    {
        public int RequestStatusSeq { get; set; }

        public string Value { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}