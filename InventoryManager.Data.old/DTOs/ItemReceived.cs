using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemReceived
    {
        public int ItemReceivedSeq { get; set; }

        public int ItemSeq { get; set; }

        public int OrderItemSeq { get; set; }

        public int WarehouseLocationSeq { get; set; }

        [StringLength(20)]
        public string SKU { get; set; }

        [StringLength(160)]
        public string ItemDescription { get; set; }

        public DateTime DateReceived { get; set; }

        public int ConversionFactor { get; set; }

        public int QuantityReceived { get; set; }

        public int? QuantityLeft { get; set; }

        public decimal UnitCost { get; set; }

        [Required]
        [StringLength(60)]
        public string UnitType { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}