using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM")]
    public partial class Item : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            ItemLocations = new HashSet<ItemLocation>();
            ItemManufacturers = new HashSet<ItemManufacturer>();
            ItemPriceHistory = new HashSet<ItemPriceHistory>();
            ItemsReceived = new HashSet<ItemReceived>();
            RequestItems = new HashSet<RequestItem>();
        }

        [Key]
        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("ITEM_MASTER_SEQ")]
        public int? ItemMasterSeq { get; set; }

        [StringLength(20)]
        [Required]
        [Column("SKU")]
        public string SKU { get; set; }

        [Required]
        [StringLength(250)]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [StringLength(20)]
        [Column("COMMODITY_CODE")]
        public string CommodityCode { get; set; }

        [Required]
        [Column("CURRENT_ISSUE_PRICE")]
        public decimal CurrentIssuePrice { get; set; }

        [Column("AVERAGE_COST")]
        public decimal AverageCost { get; set; }

        [Column("LAST_RECEIPT_COST")]
        public decimal LastReceiptCost { get; set; }

        [Column("STOCK_STATUS_SEQ")]
        public int StockStatusSeq { get; set; }

        [Column("STOCK_TYPE_SEQ")]
        public int StockTypeSeq { get; set; }

        [Column("ORDER_UNIT_SEQ")]
        public int? OrderUnitSeq { get; set; }

        [Column("ISSUE_UNIT_SEQ")]
        public int? IssueUnitSeq { get; set; }

        [Column("QUANTITY_ON_HAND")]
        public int QuantityOnHand { get; set; }

        [Column("QUANTITY_ON_ORDER")]
        public int QuantityOnOrder { get; set; }

        [Column("REORDER_POINT")]
        public int ReorderPoint { get; set; }

        [Column("REORDER_QUANTITY")]
        public int ReorderQuantity { get; set; }

        [StringLength(2000)]
        [Column("COMMENTS")]
        public string Comments { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [Column("ROTATING")]
        public bool Rotating { get; set; }

        [Column("COUNT_FREQUENCY")]
        public int? CountFrequency { get; set; }

        [StringLength(1)]
        [Column("ABC_TYPE")]
        public string ABCType { get; set; }

        [Column("LEAD_TIME")]
        public int LeadTime { get; set; }

        [Column("CONVERSION_FACTOR")]
        public int ConversionFactor { get; set; }

        [Column("REVIEWED")]
        public bool Reviewed { get; set; }

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
        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemManufacturer> ItemManufacturers { get; set; }

        public virtual ItemMaster ItemMaster { get; set; }

        public virtual StockStatus StockStatus { get; set; }

        public virtual StockType StockType { get; set; }

        public virtual OrderUnit OrderUnit { get; set; }

        public virtual IssueUnit IssueUnit { get; set; }

        public virtual Storeroom Storeroom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPriceHistory> ItemPriceHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemReceived> ItemsReceived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestItem> RequestItems { get; set; }

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
