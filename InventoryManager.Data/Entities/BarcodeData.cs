using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("BARCODE_DATA")]
    public partial class BarcodeData : ITrackable
    {
        [Key]
        [Column("BARCODE_DATA_SEQ")]
        public int BarcodeSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }
        [Column("ITEM_ADJUSTMENT_SEQ")]
        public int? ItemAdjustmentSeq { get; set; }

        [Column("DATE_SCANNED")]
        public DateTime DateScanned { get; set; }

        [StringLength(250)]
        [Column("USER_ID")]
        public string UserId { get; set; }

        [StringLength(120)]
        [Column("STOREROOM_NAME")]
        public string StoreroomName { get; set; }

        [StringLength(20)]
        [Column("SKU")]
        public string SKU { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("IS_VALID")]
        public bool IsValid { get; set; }

        [Column("BATCH_DATE")]
        public DateTime BatchDate { get; set; }

        [Column("BATCH_GUID")]
        [StringLength(32)]
        public string BatchGuid { get; set; }

        public virtual ItemAdjustment ItemAdjustment { get; set; }

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
            get { return BarcodeSeq; }
        }

        #endregion
    }
}