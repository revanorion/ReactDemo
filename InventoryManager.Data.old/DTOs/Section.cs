using System;

namespace InventoryManager.Data.DTOs
{
    public class Section
    {
        public int SectionSeq { get; set; }

        public int DivisionSeq { get; set; }

        public string SectionCode { get; set; }

        public string SectionDescription { get; set; }

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
