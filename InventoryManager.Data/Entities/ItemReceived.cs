using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_RECEIVED")]
    public partial class ItemReceived : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemReceived()
        {
            ItemIssuedReceived = new HashSet<ItemIssuedReceived>();
        }

        [Key]
        [Column("ITEM_RECEIVED_SEQ")]
        public int ItemReceivedSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("ORDER_ITEM_SEQ")]
        public int OrderItemSeq { get; set; }

        [Column("WAREHOUSE_LOCATION_SEQ")]
        public int WarehouseLocationSeq { get; set; }

        [StringLength(20)]
        [Column("SKU")]
        public string SKU { get; set; }

        [StringLength(160)]
        [Column("ITEM_DESCRIPTION")]
        public string ItemDescription { get; set; }

        [Column("DATE_RECEIVED")]
        public DateTime DateReceived { get; set; }

        [Column("CONVERSION_FACTOR")]
        public int ConversionFactor { get; set; }

        [Column("QUANTITY_RECEIVED")]
        public int QuantityReceived { get; set; }

        [Column("QUANTITY_LEFT")]
        public int? QuantityLeft { get; set; }

        [Column("UNIT_COST")]
        public decimal UnitCost { get; set; }

        [Required]
        [StringLength(60)]
        [Column("UNIT_TYPE")]
        public string UnitType { get; set; }

        [StringLength(50)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual Item Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemIssuedReceived> ItemIssuedReceived { get; set; }

        public virtual OrderItem OrderItem { get; set; }

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
            get { return ItemReceivedSeq; }
        }

        #endregion
    }
}
