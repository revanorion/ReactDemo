using System;

namespace InventoryManager.Data.DTOs
{
    public class Department
    {
        public int DepartmentSeq { get; set; }

        public string DepartmentCode { get; set; }

        public string DepartmentDescription { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}
