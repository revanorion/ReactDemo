using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public partial class Item
    {
        public int ItemSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public int StoreroomSeq { get; set; }

        public int? ItemMasterSeq { get; set; }

        [StringLength(20)]
        public string SKU { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(20)]
        public string CommodityCode { get; set; }

        [Required]
        public decimal CurrentIssuePrice { get; set; }

        public decimal? AverageCost { get; set; }

        public decimal? LastReceiptCost { get; set; }

        public int StockStatusSeq { get; set; }

        public int StockTypeSeq { get; set; }

        public int? OrderUnitSeq { get; set; }

        public int? IssueUnitSeq { get; set; }

        public int QuantityOnHand { get; set; }

        public int QuantityOnOrder { get; set; }

        public int ReorderPoint { get; set; }

        public int ReorderQuantity { get; set; }

        [StringLength(2000)]
        public string Comments { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        public bool Rotating { get; set; }

        public int? CountFrequency { get; set; }

        [StringLength(1)]
        public string ABCType { get; set; }

        public int LeadTime { get; set; }

        public int? ConversionFactor { get; set; }

        public bool Reviewed { get; set; }

        public bool RequireAssestTagOnIssue { get; set; }

        public bool IsHurricaneItem { get; set; }

        public bool IsLoanableItem { get; set; }

        public bool IsSafetyEquipment { get; set; }

        public bool IsEmergencyItem { get; set; }

        public bool IsKnockDownItem { get; set; }
        public bool IsActive { get; set; }

        public List<ItemLocation> ItemLocations { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}
