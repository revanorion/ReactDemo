using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("USER_STOREROOM")]
    public partial class UserStoreroom : ITrackable
    {
        [Key]
        [Column("USER_STOREROOM_SEQ")]
        public int UserStoreroomSeq { get; set; }

        [Column("USER_SEQ")]
        public int UserSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("IS_DEFAULT_STOREROOM")]
        public bool IsDefaultStoreroom { get; set; }

        public virtual Storeroom Storeroom { get; set; }

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
            get { return UserStoreroomSeq; }
        }

        #endregion
    }
}
