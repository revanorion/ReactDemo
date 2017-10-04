using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("WAREHOUSE")]
    public partial class Warehouse : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            Orders = new HashSet<Order>();
            Requests = new HashSet<Request>();
            Storerooms = new HashSet<Storeroom>();
            TrackingNumbers = new HashSet<TrackingNumber>();
            UserWarehouseRoles = new HashSet<UserWarehouse>();
            WarehouseLocations = new HashSet<WarehouseLocation>();
        }

        [Key]
        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Required]
        [StringLength(120)]
        [Column("WAREHOUSE_NAME")]
        public string WarehouseName { get; set; }

        [StringLength(2000)]
        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("ADVANTAGE_DEPARTMENT_CODE")]
        public int AdvantageDepartmentCode { get; set; }

        [Column("ADVANTAGE_FUND_CODE")]
        public int AdvantageFundCode { get; set; }

        [Column("ADVANTAGE_UNIT_CODE")]
        public int AdvantageUnitCode { get; set; }

        [Column("ISSUE_METHOD")]
        public int IssueMethod { get; set; }

        [Column("COSTING_METHOD")]
        public int CostingMethod { get; set; }

        [Column("ADVANCED_FEATURES")]
        public bool? HasAdvancedFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Storeroom> Storerooms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackingNumber> TrackingNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserWarehouse> UserWarehouseRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseLocation> WarehouseLocations { get; set; }

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
            get { return WarehouseSeq; }
        }

        #endregion
    }
}
