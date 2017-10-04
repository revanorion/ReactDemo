using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public partial class BarcodeData
    {
        public int BarcodeSeq { get; set; }

        public int WarehouseSeq { get; set; }
        public int? ItemAdjustmentSeq { get; set; }

        public DateTime DateScanned { get; set; }

        [StringLength(250)]
        [Display(Name = "User Id")]
        public string UserId { get; set; }

        [StringLength(120)]
        [Display(Name = "Storeroom Name")]
        public string StoreroomName { get; set; }

        [StringLength(20)]
        public string SKU { get; set; }

        public int Quantity { get; set; }

        public bool IsValid { get; set; }
        public DateTime BatchDate { get; set; }

        [StringLength(32)]
        public string BatchGuid { get; set; }

        
        public string Errors { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}