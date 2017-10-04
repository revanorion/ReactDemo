using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class WarehouseLocation
    {
        public int WarehouseLocationSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public int? ParentSeq { get; set; }

        public int? StoreroomSeq { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        public string Notes { get; set; }

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