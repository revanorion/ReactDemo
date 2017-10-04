using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class Storeroom
    {
        public int StoreroomSeq { get; set; }

        public int WarehouseSeq { get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(60)]
        public string StoreroomName { get; set; }
        [Required]

        [StringLength(250)]
        public string Description { get; set; }

        public bool IsVehicle { get; set; }

        public bool IsActive { get; set; }
        [Required]
        public int RegionSeq { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}