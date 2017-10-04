using System;
using System.Collections.Generic;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class Request
    {
        public int RequestSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public int StoreroomSeq { get; set; }

        public int RequestStatusSeq { get; set; }

        public DateTime? RequestedOn { get; set; }

        public int? RequestedBy { get; set; }

        public DateTime? ApprovedOn { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? IssuedOn { get; set; }

        public int? IssuedBy { get; set; }

        public string Source { get; set; }

        public string Comments { get; set; }

        public int? TrackingValue { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion

        // Additional properties not found in the related Entity:
        public List<RequestItemView> RequestItemsView { get; set; }

        public List<RequestItem> RequestItems { get; set; }
        public string RequestedOnFormatted
        {
            get
            {
                return RequestedOn != null ? RequestedOn.Value.ToString("MM/dd/yyyy hh:mm tt") : string.Empty;
            }
        }

        public string ApprovedOnFormatted
        {
            get
            {
                return ApprovedOn != null ? ApprovedOn.Value.ToString("MM/dd/yyyy hh:mm tt") : string.Empty;
            }
        }

        public string IssuedOnFormatted
        {
            get
            {
                return IssuedOn != null ? IssuedOn.Value.ToString("MM/dd/yyyy hh:mm tt") : string.Empty;
            }
        }
    }
}