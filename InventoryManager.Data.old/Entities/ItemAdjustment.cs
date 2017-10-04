using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_ADJUSTMENT")]
    public partial class ItemAdjustment : ITrackable
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemAdjustment()
        {
            BarcodeData = new HashSet<BarcodeData>();
        }

        [Key]
        [Column("ITEM_ADJUSTMENT_SEQ")]
        public int ItemAdjustmentSeq { get; set; }

        [Column("WAREHOUSE_LOCATION_SEQ")]
        public int WarehouseLocationSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("OLD_QUANTITY")]
        public int OldQuantity { get; set; }

        [Column("UNIT_COST")]
        public decimal UnitCost { get; set; }

        [Column("OLD_UNIT_COST")]
        public decimal OldUnitCost { get; set; }

        [Column("ADJUSTMENT_STATUS_SEQ")]
        public int AdjustmentStatusSeq { get; set; }

        [Column("ADJUSTMENT_REASON_SEQ")]
        public int AdjustmentReasonSeq { get; set; }

        [StringLength(800)]
        [Column("COMMENTS")]
        public string Comments { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [Column("CREATED_ON")]
        public DateTime CreatedOn { get; set; }

        [Column("CREATED_BY")]
        public int CreatedBy { get; set; }

        [Column("APPROVED_ON")]
        public DateTime ApprovedOn { get; set; }

        [Column("APPROVED_BY")]
        public int? ApprovedBy { get; set; }

        public virtual Item Item { get; set; }
        public virtual AdjustmentStatus AdjustmentStatus { get; set; }
        public virtual AdjustmentReason AdjustmentReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BarcodeData> BarcodeData { get; set; }

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
            get { return ItemAdjustmentSeq; }
        }

        #endregion
    }
}
