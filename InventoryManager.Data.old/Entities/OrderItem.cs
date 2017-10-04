using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ORDER_ITEM")]
    public partial class OrderItem : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItem()
        {
            ItemsReceived = new HashSet<ItemReceived>();
        }

        [Key]
        [Column("ORDER_ITEM_SEQ")]
        public int OrderItemSeq { get; set; }

        [Column("ORDER_SEQ")]
        public int OrderSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int? ItemSeq { get; set; }

        [StringLength(20)]
        [Column("SKU")]
        public string SKU { get; set; }

        [StringLength(160)]
        [Column("ITEM_DESCRIPTION")]
        public string ItemDescription { get; set; }

        [Column("LINE_NUMBER")]
        public int? LineNumber { get; set; }

        [StringLength(14)]
        [Column("COMMODITY_CODE")]
        public string CommodityCode { get; set; }

        [Column("UNIT_PRICE")]
        public decimal UnitPrice { get; set; }

        [Required]
        [StringLength(4)]
        [Column("UNIT_MEASURE")]
        public string UnitMeasure { get; set; }

        [Column("QUANTITY_ORDERED")]
        public int QuantityOrdered { get; set; }

        [Column("CONVERSION_FACTOR")]
        public int ConversionFactor { get; set; }

        [Column("QUANTITY_RECEIVED")]
        public int? QuantityReceived { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [StringLength(20)]
        [Column("VENDOR_CODE")]
        public string VendorCode { get; set; }

        [StringLength(60)]
        [Column("VENDOR_NAME")]
        public string VendorName { get; set; }

        [StringLength(25)]
        [Column("MANUFACTURER_NAME")]
        public string ManufacturerName { get; set; }

        [StringLength(25)]
        [Column("PART_NUMBER")]
        public string ManufacturerPartNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemReceived> ItemsReceived { get; set; }

        public virtual Order Order { get; set; }

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
            get { return OrderItemSeq; }
        }

        #endregion
    }
}
