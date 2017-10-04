using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_REQUEST_ITEM")]
    public class RequestItemView
    {
        [Key]
        [Column("REQUEST_ITEM_SEQ")]
        public int RequestItemSeq { get; set; }

        [Column("REQUEST_SEQ")]
        public int RequestSeq { get; set; }

        [Column("REQUESTED_ON")]
        public DateTime? RequestedOn { get; set; }

        [Column("REQUESTED_BY")]
        public int RequestedBy { get; set; }

        [Column("REQUESTED_BY_NAME")]
        public string RequestedByName { get; set; }

        [Column("REQUEST_STATUS_SEQ")]
        public int RequestStatusSeq { get; set; }

        [Column("STATUS")]
        public string Status { get; set; }

        [Column("APPROVED_ON")]
        public DateTime? ApprovedOn { get; set; }

        [Column("APPROVED_BY")]
        public int? ApprovedBy { get; set; }

        [Column("APPROVED_BY_NAME")]
        public string ApprovedByName { get; set; }

        [Column("ISSUED_ON")]
        public DateTime? IssuedOn { get; set; }

        [Column("ISSUED_BY")]
        public int? IssuedBy { get; set; }

        [Column("ISSUED_BY_NAME")]
        public string IssuedByName { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("SKU")]
        public string SKU { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("QUANTITY_ISSUED")]
        public int? QuantityIssued { get; set; }

        [Column("TRACKING_VALUE")]
        public int? TrackingValue { get; set; }

        [Column("WORK_ORDER_NUMBER")]
        public int? WorkOrderNumber { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("STOREROOM_NAME")]
        public string StoreroomName { get; set; }

        [Column("DESTINATION_STOREROOM_SEQ")]
        public int? DestinationStoreroomSeq { get; set; }

        [Column("DESTINATION_STOREROOM_NAME")]
        public string DestinationStoreroomName { get; set; }
        
    }
}
