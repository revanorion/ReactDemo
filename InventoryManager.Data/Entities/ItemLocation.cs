using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_LOCATION")]
    public partial class ItemLocation : ITrackable
    {
        [Key]
        [Column("ITEM_LOCATION_SEQ")]
        public int ItemLocationSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("WAREHOUSE_LOCATION_SEQ")]
        public int WarehouseLocationSeq { get; set; }

        [Column("QUANTITY_AT_LOCATION")]
        public int QuantityAtLocation { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual Item Item { get; set; }

        public virtual WarehouseLocation WarehouseLocation { get; set; }

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
            get { return ItemLocationSeq; }
        }

        #endregion
    }
}
