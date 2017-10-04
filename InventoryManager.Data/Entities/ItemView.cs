using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_ITEM")]
    public partial class ItemView : ITrackable
    {
        [Key]
        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("ITEM_MASTER_SEQ")]
        public int? ItemMasterSeq { get; set; }

        [Column("SKU")]
        public string SKU { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("COMMODITY_CODE")]
        public string CommodityCode { get; set; }

        [Column("CURRENT_ISSUE_PRICE")]
        public decimal CurrentIssuePrice { get; set; }

        [Column("AVERAGE_COST")]
        public decimal? AverageCost { get; set; }

        [Column("LAST_RECEIPT_COST")]
        public decimal? LastReceiptCost { get; set; }

        [Column("STOCK_STATUS_SEQ")]
        public int StockStatusSeq { get; set; }

        [Column("STOCK_STATUS")]
        public string StockStatus { get; set; }

        [Column("STOCK_TYPE_SEQ")]
        public int StockTypeSeq { get; set; }

        [Column("STOCK_TYPE")]
        public string StockType { get; set; }

        [Column("ORDER_UNIT_SEQ")]
        public int? OrderUnitSeq { get; set; }

        [Column("ORDER_UNIT")]
        public string OrderUnit { get; set; }

        [Column("ISSUE_UNIT_SEQ")]
        public int? IssueUnitSeq { get; set; }

        [Column("ISSUE_UNIT")]
        public string IssueUnit { get; set; }

        [Column("QUANTITY_ON_HAND")]
        public int QuantityOnHand { get; set; }

        [Column("QUANTITY_ON_ORDER")]
        public int QuantityOnOrder { get; set; }

        [Column("REORDER_POINT")]
        public int ReorderPoint { get; set; }

        [Column("REORDER_QUANTITY")]
        public int ReorderQuantity { get; set; }

        [Column("COMMENTS")]
        public string Comments { get; set; }

        [Column("SOURCE")]
        public string Source { get; set; }

        [Column("ROTATING")]
        public bool Rotating { get; set; }

        [Column("COUNT_FREQUENCY")]
        public int? CountFrequency { get; set; }

        [Column("ABC_TYPE")]
        public string ABCType { get; set; }

        [Column("LEAD_TIME")]
        public int LeadTime { get; set; }

        [Column("CONVERSION_FACTOR")]
        public int? ConversionFactor { get; set; }

        [Column("REVIEWED")]
        public bool? Reviewed { get; set; }

        [Column("REQUIRE_ASSEST_TAG_ON_ISSUE")]
        public bool RequireAssestTagOnIssue { get; set; }

        [Column("IS_HURRICANE_ITEM")]
        public bool IsHurricaneItem { get; set; }

        [Column("IS_LOANABLE_ITEM")]
        public bool IsLoanableItem { get; set; }

        [Column("IS_SAFETY_EQUIPMENT")]
        public bool IsSafetyEquipment { get; set; }

        [Column("IS_EMERGENCY_ITEM")]
        public bool IsEmergencyItem { get; set; }

        [Column("IS_KNOCK_DOWN_ITEM")]
        public bool IsKnockDownItem { get; set; }

        #region ITrackable Properties
        [Column("USER_SEQ_ENT_BY")]
        public int? UserSeqEnteredBy { get; set; }
        [Column("DT_ENT")]
        public DateTime? DateEntered { get; set; }
        [Column("USER_SEQ_CHG_BY")]
        public int? UserSeqChangedBy { get; set; }
        [Column("DT_CHG")]
        public DateTime? DateChanged { get; set; }

        [NotMapped]
        public int Id
        {
            get { return ItemSeq; }
        }

        #endregion
    }
}
