using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("WAREHOUSE_LOCATION")]
    public partial class WarehouseLocation : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WarehouseLocation()
        {
            ItemLocations = new HashSet<ItemLocation>();
            WarehouseLocations = new HashSet<WarehouseLocation>();
        }

        [Key]
        [Column("WAREHOUSE_LOCATION_SEQ")]
        public int WarehouseLocationSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("PARENT_SEQ")]
        public int? ParentSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int? StoreroomSeq { get; set; }

        [Required]
        [StringLength(60)]
        [Column("NAME")]
        public string Name { get; set; }

        [Column("NOTES")]
        public string Notes { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseLocation> WarehouseLocations { get; set; }

        public virtual WarehouseLocation WarehouseLocation2 { get; set; }

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
            get { return WarehouseLocationSeq; }
        }

        #endregion
    }
}
