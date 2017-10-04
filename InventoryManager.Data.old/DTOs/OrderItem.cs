using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class OrderItem
    {
        public int OrderItemSeq { get; set; }

        public int OrderSeq { get; set; }

        public int? ItemSeq { get; set; }

        [StringLength(20)]
        public string SKU { get; set; }

        [StringLength(160)]
        public string ItemDescription { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(14)]
        public string CommodityCode { get; set; }

        public decimal UnitPrice { get; set; }

        [Required]
        [StringLength(4)]
        public string UnitMeasure { get; set; }

        [Required]
        public int QuantityOrdered { get; set; }

        [Required]
        public int ConversionFactor { get; set; }

        [Required]
        public int? QuantityReceived { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        [StringLength(20)]
        public string VendorCode { get; set; }

        [StringLength(60)]
        public string VendorName { get; set; }

        [StringLength(25)]
        public string ManufacturerName { get; set; }

        [StringLength(25)]
        public string ManufacturerPartNumber { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}