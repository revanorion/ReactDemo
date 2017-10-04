using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("TRACKING_NUMBER")]
    public partial class TrackingNumber : ITrackable
    {
        [Key]
        [Column("TRACKING_NUMBER_SEQ")]
        public int TrackingNumberSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int? WarehouseSeq { get; set; }

        [Required]
        [StringLength(60)]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

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
            get { return TrackingNumberSeq; }
        }

        #endregion
    }
}
