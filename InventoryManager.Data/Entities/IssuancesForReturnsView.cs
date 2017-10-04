using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_ISSUANCES_FOR_RETURNS")]
    public class IssuancesForReturnsView
    {
        [Key]
        [Column("ITEM_ISSUED_SEQ")]
        public int ItemIssuedSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreRoomSeq { get; set; }

        [Column("DATE_ISSUED")]
        public DateTime DateIssued { get; set; }

        [Column("REQUEST_ITEM_SEQ")]
        public int RequestItemSeq { get; set; }

        [Column("REQUEST_SEQ")]
        public int RequestSeq { get; set; }       

        [Column("QUANTITY_ISSUED")]
        public int QuantityIssued { get; set; }

        [Column("QUANTITY_RETURNED")]
        public int QuantityReturned { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("SKU")]
        public string SKU { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("ISSUE_UNIT_TYPE")]
        public string IssueUnitType { get; set; }

        [Column("ISSUE_PRICE")]
        public decimal IssuePrice { get; set; }

        [Column("REQUESTED_BY")]
        public int RequestedBy { get; set; }

        [Column("TRACKING_VALUE")]
        public int TrackingValue { get; set; }
        [Column("SOURCE")]
        public string Source { get; set; }

        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }
    }
}
