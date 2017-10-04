using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_REGION")]
    public class Region : ITrackable
    {
        [Key]
        [Column("REGION_SEQ")]
        public int RegionSeq { get; set; }

        [Column("DIVISION_SEQ")]
        public int DivisionSeq { get; set; }

        [Column("REGION_CODE")]
        public string RegionCode { get; set; }

        [Column("REGION_DESC")]
        public string RegionDescription { get; set; }

        [Column("START_DATE")]
        public DateTime? StartDate { get; set; }

        [Column("END_DATE")]
        public DateTime? EndDate { get; set; }

        #region ITrackable Properties
        [Column("USER_SEQ_ENT_BY")]
        public int? UserSeqEnteredBy { get; set; }
        [Column("DT_ENT")]
        public DateTime? DateEntered { get; set; }
        [Column("USER_SEQ_CHG_BY")]
        public int? UserSeqChangedBy { get; set; }
        [Column("DT_CHG")]
        public DateTime? DateChanged { get; set; }

        [NotMapped]
        public int Id
        {
            get { return RegionSeq; }
        }
        #endregion
    }
}
