using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("WORK_ORDER")]
    public partial class WorkOrder : ITrackable
    {
        [Key]
        [Column("WORK_ORDER_SEQ")]
        [DisplayName("Tracking #")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long WorkOrderId { get; set; }

        [Column("WORK_TYPE_SEQ")]
        [Required(ErrorMessage = "The Work Order Type is required!")]
        public byte WorkOrderTypeId { get; set; }

        [Column("REPORTED_ON")]
        [DisplayName("Reported On")]
        public System.DateTime ReportedOn { get; set; }

        [Column("TITLE")]
        [MaxLength(100, ErrorMessage = "The Title must have a maximum length of 100 characters")]
        [Required(ErrorMessage = "The Title is required!")]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        [MaxLength(2000, ErrorMessage = "The Description must have a maximum length of 2000 characters")]
        [Required(ErrorMessage = "The Description is required!")]
        public string Description { get; set; }

        [Column("STATUS_SEQ")]
        public byte StatusId { get; set; }

        [Column("STATUS_DATE")]
        public DateTime StatusDate { get; set; }

        [Column("AGENCY_SEQ")]
        public int? AgencyId { get; set; }

        [Column("DIVISION_SEQ")]
        [Required(ErrorMessage = "The Division is required!")]
        public short DivisionId { get; set; }

        [Column("LOCATION_SEQ")]        
        [Range(1, int.MaxValue)]
        [Required(ErrorMessage = "The Location is required!")]
        public int LocationId { get; set; }
        
        [Column("PRIORITY_SEQ")]
        [Required(ErrorMessage = "The Priority is required!")]
        public byte PriorityId { get; set; }       

        [Column("BILLING_ACCOUNT_SEQ")]
        public int? BillingAccountId { get; set; }

        [Column("MAINTENANCE_IND")]
        [DefaultValue(false)]
        public bool IsMaintenance { get; set; }

        [Column("BILLABLE_IND")]
        [DefaultValue(false)]
        public bool IsBillable { get; set; }

        [Column("EMERGENCY_IND")]
        [DefaultValue(false)]
        public bool IsEmergency { get; set; }

        [Column("SERVICE_RESTORED")]
        public DateTime? RestoredDate { get; set; }

        [Column("ORIGINAL_WO")]
        public long? OriginatingWO { get; set; }

        [Display(Name = "Reported By:")]
        [MaxLength(200, ErrorMessage = "The Reported By must have a maximum length of 200 characters")]
        [Column("REPORTED_BY")]
        public string ReportedBy { get; set; }

        [StringLength(25)]
        [Display(Name = "Phone #:")]
        [Column("REPORTED_BY_PHONE_NUMBER")]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Not a valid Phone number")]
        public string ReportedByPhoneNumber { get; set; }

        [StringLength(50)]
        [Display(Name = "Email:")]
        [Column("REPORTED_BY_EMAIL")]
        [DataType(DataType.EmailAddress)]
        public string ReportedByEmail { get; set; }

        [Display(Name = "Point Of Contact:")]
        [MaxLength(200, ErrorMessage = "The Point of Contact must have a maximum length of 200 characters")]
        [Column("CONTACT_NAME")]
        public string PointOfContact { get; set; }

        [StringLength(25)]
        [Display(Name = "Phone #:")]
        [Column("CONTACT_PHONE_NUMBER")]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Not a valid Phone number")]
        public string PointOfContactPhoneNumber { get; set; }

        [StringLength(50)]
        [Display(Name = "Email:")]
        [Column("CONTACT_EMAIL")]
        [DataType(DataType.EmailAddress)]
        public string PointOfContactEmail { get; set; }
        
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
            get { return Convert.ToInt32(WorkOrderId); }
        }

        #endregion

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RequestItem> RequestItemCollection { get; set; }

        public WorkOrder()
        {
            //this.RequestItemCollection = new HashSet<RequestItem>();
        }
    }
}
