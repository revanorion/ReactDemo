using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeTables.Data.Entities
{
    [Table("EXTERNAL_PAYMENT_TYPE")]
    public partial class ExternalPaymentType
    {

        [Key]
        [Column("PAYMENT_TYPE_SEQ")]
        public decimal PaymentTypeSeq { get; set; }

        [Column("PAYMENT_TYPE_DESC")]
        public string PaymentTypeDescription { get; set; }      

        [Column("START_DATE")]
        public DateTime? StartDate { get; set; }
        [Column("END_DATE")]
        public DateTime? EndDate { get; set; }
        
    }
}