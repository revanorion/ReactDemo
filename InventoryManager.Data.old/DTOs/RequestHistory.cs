using System;

namespace InventoryManager.Data.DTOs
{
    public class RequestHistory
    {
        public int RequestSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public int RequestStatusSeq { get; set; }

        public DateTime? RequestedOn { get; set; }

        public int? RequestedBy { get; set; }

        public DateTime? ApprovedOn { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? IssuedOn { get; set; }

        public int? IssuedBy { get; set; }

        public string Source { get; set; }

        public int? TrackingValue { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        #region IAuditable Properties
        public DateTime Timestamp { get; set; }
        #endregion
    }
}
