using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public partial class IssueUnit : IRangedClass
    {
        public int IssueUnitSeq { get; set; }

        public int? WarehouseSeq { get; set; }
        [Required]
        [StringLength(250)]
        public string Value { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}
