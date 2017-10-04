using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class RequestItem
    {
        public int RequestItemSeq { get; set; }

        public int RequestSeq { get; set; }

        public int ItemSeq { get; set; }

        public bool IsReplacementItem { get; set; }

        [StringLength(260)]
        public string ReplacementComments { get; set; }

        [Required]
        public int QuantityRequested { get; set; }

        public int? TrackingValue { get; set; }

        public int? WorkOrderNumber { get; set; }

        public int? DestinationStoreroomSeq { get; set; }

        public bool IsTransfer { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}