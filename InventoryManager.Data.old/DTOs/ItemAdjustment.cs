using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemAdjustment
    {
        public int ItemAdjustmentSeq { get; set; }

        public int WarehouseLocationSeq { get; set; }

        public int ItemSeq { get; set; }

        public int Quantity { get; set; }

        public int OldQuantity { get; set; }

        public decimal UnitCost { get; set; }

        public decimal OldUnitCost { get; set; }

        public int AdjustmentReasonSeq { get; set; }

        [StringLength(800)]
        public string Comments { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ApprovedOn { get; set; }

        public int? ApprovedBy { get; set; }

        public int AdjustmentStatusSeq { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}