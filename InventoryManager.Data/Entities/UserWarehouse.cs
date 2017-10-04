using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("USER_WAREHOUSE")]
    public partial class UserWarehouse : ITrackable
    {
        [Key]
        [Column("USER_WAREHOUSE_SEQ")]
        public int UserWarehouseSeq { get; set; }

        [Column("USER_SEQ")]
        public int UserSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

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
            get { return UserWarehouseSeq; }
        }

        #endregion
    }
}
