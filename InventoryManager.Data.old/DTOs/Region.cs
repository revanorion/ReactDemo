using System;

namespace InventoryManager.Data.DTOs
{
    public class Region : IRangedClass
    {
        public int RegionSeq { get; set; }

        public int DivisionSeq { get; set; }

        public string RegionCode { get; set; }

        public string RegionDescription { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }

        public int? WarehouseSeq
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}
