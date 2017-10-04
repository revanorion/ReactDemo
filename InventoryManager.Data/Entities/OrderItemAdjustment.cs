using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ORDER_ITEM_ADJUSTMENT")]
    public partial class OrderItemAdjustment : ITrackable
    {
        [Key]
        [Column("ORDER_ITEM_ADJUSTMENT_SEQ")]
        public int OrderItemAdjustmentSeq { get; set; }

        [Column("WAREHOUSE_LOCATION_SEQ")]
        public int WarehouseLocationSeq { get; set; }

        [Column("ORDER_ITEM_SEQ")]
        public int OrderItemSeq { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("UNIT_COST")]
        public decimal UnitCost { get; set; }

        [Required]
        [StringLength(60)]
        [Column("REASON")]
        public string Reason { get; set; }

        [StringLength(800)]
        [Column("COMMENTS")]
        public string Comments { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

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
            get { return OrderItemAdjustmentSeq; }
        }

        #endregion
    }
}
