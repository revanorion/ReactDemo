using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_MANUFACTURER")]
    public partial class ItemManufacturer : ITrackable
    {
        [Key]
        [Column("ITEM_MANUFACTURER_SEQ")]
        public int ItemManufacturerSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [StringLength(60)]
        [Column("MANUFACTURER_NAME")]
        public string ManufacturerName { get; set; }

        [StringLength(60)]
        [Column("PART_NUMBER")]
        public string PartNumber { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual Item Item { get; set; }

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
            get { return ItemManufacturerSeq; }
        }

        #endregion
    }
}
