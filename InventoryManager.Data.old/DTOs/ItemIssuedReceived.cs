using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemIssuedReceived
    {
        public int ItemReceivedSeq { get; set; }

        public int ItemIssuedSeq { get; set; }

        public int QuantityIssued { get; set; }

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