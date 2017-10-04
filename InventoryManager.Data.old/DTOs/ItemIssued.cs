using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemIssued
    {
        public int ItemIssuedSeq { get; set; }

        public DateTime DateIssued { get; set; }

        public int RequestItemSeq { get; set; }

        public int QuantityIssued { get; set; }

        public decimal? IssuePrice { get; set; }

        public int IssueUnitSeq { get; set; }

        public int? IssueCondition { get; set; }

        public bool IsLoanItem { get; set; }

        public DateTime? LoanExpiration { get; set; }

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