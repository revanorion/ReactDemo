using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class OrganizationStructure
    {
        public int OrganizationStructureSeq { get; set; }

        public int? TypeSeq { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Acronym { get; set; }

        public int? ParentSeq { get; set; }

        public int? OrganizationLevel { get; set; }

        public int? HeadPositionSeq { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}