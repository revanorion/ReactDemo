using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("STOREROOM")]
    public partial class Storeroom : ITrackable
    {
        [Key]
        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [StringLength(60)]
        [Column("STOREROOM_NAME")]
        public string StoreroomName { get; set; }

        [StringLength(250)]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("IS_VEHICLE")]
        public bool IsVehicle { get; set; }

        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }

        [Column("REGION_SEQ")]
        public int RegionSeq { get; set; }

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
            get { return StoreroomSeq; }
        }

        #endregion
    }
}
