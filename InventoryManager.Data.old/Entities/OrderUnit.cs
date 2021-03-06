using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ORDER_UNIT")]
    public partial class OrderUnit : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderUnit()
        {
            //ItemMasters = new HashSet<ItemMaster>();
            Items = new HashSet<Item>();
        }

        [Key]
        [Column("ORDER_UNIT_SEQ")]
        public int OrderUnitSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int? WarehouseSeq { get; set; }

        [StringLength(250)]
        [Column("VALUE")]
        public string Value { get; set; }

        [Column("START_DATE")]
        public DateTime? StartDate { get; set; }
        [Column("END_DATE")]
        public DateTime? EndDate { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ItemMaster> ItemMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

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
            get { return OrderUnitSeq; }
        }

        #endregion
    }
}
