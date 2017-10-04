using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemManufacturer
    {
        public int ItemManufacturerSeq { get; set; }

        public int ItemSeq { get; set; }

        [StringLength(60)]
        public string ManufacturerName { get; set; }

        [StringLength(60)]
        public string PartNumber { get; set; }

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