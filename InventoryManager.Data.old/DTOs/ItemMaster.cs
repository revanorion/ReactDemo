using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class ItemMaster
    {
        public int ItemMasterSeq { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Item")]
        public string SKU { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(20)]
        public string CommodityCode { get; set; }

        [Required]
        [Display(Name="Standard Cost")]
        [RegularExpression(@"\d+(\.\d{0,4})?", ErrorMessage = "Standard Cost must be a number with a maximum of 4 decimal places.")]
        public decimal StandardCost { get; set; }

        public bool Rotating { get; set; }

        public bool SDS { get; set; }

        [Display(Name="Stock Type")]
        public int StockTypeSeq { get; set; }

        public int WarehouseSeq { get; set; }
        public bool IsActive { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}