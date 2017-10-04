using System;

namespace InventoryManager.Data.DTOs
{
    public class Division
    {
        public int DivisionSeq { get; set; }

        public int DepartmentSeq { get; set; }

        public string DivisionCode { get; set; }

        public string DivisionDescription { get; set; }

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
