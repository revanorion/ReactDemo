using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class TrackingNumber
    {
        public int TrackingNumberSeq { get; set; }

        public int? WarehouseSeq { get; set; }

        [Required]
        [StringLength(60)]
        public string Description { get; set; }

        public bool IsActive { get; set; }

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