using System;

namespace InventoryManager.Data.DTOs
{
    public class UserStoreroom
    {
        public int UserStoreroomSeq { get; set; }

        public int UserSeq { get; set; }

        public int StoreroomSeq { get; set; }

        public bool IsDefaultStoreroom { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}
