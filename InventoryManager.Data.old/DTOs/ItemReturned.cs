using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemReturned
    {
        public int ItemReturnedSeq { get; set; }

        public int ItemIssuedSeq { get; set; }

        public int QuantityReturned { get; set; }

        public DateTime ReturnDate { get; set; }

        public int? ReturnCondition { get; set; }

        [StringLength(4000)]
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