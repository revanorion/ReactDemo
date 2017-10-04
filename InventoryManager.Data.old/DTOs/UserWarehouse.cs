using System;

namespace InventoryManager.Data.DTOs
{
    public class UserWarehouse
    {
        public int UserWarehouseSeq { get; set; }

        public int UserSeq { get; set; }

        public int WarehouseSeq { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}