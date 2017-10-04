using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class OrderItemAdjustment
    {
        public int OrderItemAdjustmentSeq { get; set; }

        public int WarehouseLocationSeq { get; set; }

        public int OrderItemSeq { get; set; }

        public int Quantity { get; set; }

        public decimal UnitCost { get; set; }

        [Required]
        [StringLength(60)]
        public string Reason { get; set; }

        [StringLength(800)]
        public string Comments { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}