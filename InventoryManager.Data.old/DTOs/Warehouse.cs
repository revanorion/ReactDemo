using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class Warehouse
    {
        public int WarehouseSeq { get; set; }

        [Required]
        [StringLength(120)]
        public string WarehouseName { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public int OrganizationStructureSeq { get; set; }

        public int AdvantageDepartmentCode { get; set; }

        public int AdvantageFundCode { get; set; }

        public int AdvantageUnitCode { get; set; }

        public int IssueMethod { get; set; }

        public int CostingMethod { get; set; }

        public bool? HasAdvancedFeatures { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}