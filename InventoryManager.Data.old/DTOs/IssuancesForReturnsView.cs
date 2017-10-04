using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class IssuancesForReturnsView
    {
        public int ItemIssuedSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public int StoreroomSeq { get; set; }

        public DateTime DateIssued { get; set; }

        public int RequestItemSeq { get; set; }

        public int RequestSeq { get; set; }

        public int QuantityIssued { get; set; }

        public int QuantityReturned { get; set; }

        public int ItemSeq { get; set; }

        public string SKU { get; set; }

        public string Description { get; set; }

        public string IssueUnitType { get; set; }

        public decimal IssuePrice { get; set; }

        public int RequestedBy { get; set; }

        public int? TrackingValue { get; set; }
        public string Source { get; set; }
        public bool IsActive { get; set; }

        // Additional properties not found in the related Entity
        [Required]
        [Display(Name = "Returned By")]
        public string RetrurnBy { get; set; }

        public int? ReturnUserSeq { get; set; }
    }
}
