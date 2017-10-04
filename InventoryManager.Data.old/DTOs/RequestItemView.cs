using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class RequestItemView
    {
        public int RequestItemSeq { get; set; }

        public int RequestSeq { get; set; }

        public DateTime? RequestedOn { get; set; }

        public int RequestedBy { get; set; }

        public string RequestedByName { get; set; }

        public int RequestStatusSeq { get; set; }

        public string Status { get; set; }

        public DateTime? ApprovedOn { get; set; }

        public int? ApprovedBy { get; set; }

        public string ApprovedByName { get; set; }

        public DateTime? IssuedOn { get; set; }

        public int? IssuedBy { get; set; }

        public string IssuedByName { get; set; }

        public int ItemSeq { get; set; }

        public string SKU { get; set; }

        [Required]
        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Invalid Quantity: must be an integer between 1 and 2147483647.")]
        public int Quantity { get; set; }

        public int? QuantityIssued { get; set; }

        public int? TrackingValue { get; set; }

        public int? WorkOrderNumber { get; set; }

        public int StoreroomSeq { get; set; }

        public string StoreroomName { get; set; }

        public int? DestinationStoreroomSeq { get; set; }

        public string DestinationStoreroomName { get; set; }        
        public string FullWorkOrder { get; set; }

        // Additional properties not found in the related Entity:

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
