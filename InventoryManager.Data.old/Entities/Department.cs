using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_DEPARTMENT")]
    public class Department : ITrackable
    {
        [Key]
        [Column("DEPARTMENT_SEQ")]
        public int DepartmentSeq { get; set; }

        [Column("DEPARTMENT_CODE")]
        public string DepartmentCode { get; set; }

        [Column("DEPARTMENT_DESC")]
        public string DepartmentDescription { get; set; }

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
            get { return DepartmentSeq; }
        }
        #endregion
    }
}
