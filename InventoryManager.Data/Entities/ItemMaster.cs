using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_MASTER")]
    public partial class ItemMaster : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemMaster()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        [Column("ITEM_MASTER_SEQ")]
        public int ItemMasterSeq { get; set; }

        [Required]
        [StringLength(20)]
        [Index("IX_ITEM_MASTER_SKU", IsUnique = true)]
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
        [Column("STANDARD_COST")]
        public decimal StandardCost { get; set; }

        [Column("ROTATING")]
        public bool Rotating { get; set; }

        [Column("SDS")]
        public bool SDS { get; set; }

        [Required]
        [Column("STOCK_TYPE_SEQ")]
        public int StockTypeSeq { get; set; }

        [Required]
        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

        public virtual StockType StockType { get; set; }

        public virtual Warehouse Warehouse { get; set; }

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
            get { return ItemMasterSeq; }
        }

        #endregion
    }
}
