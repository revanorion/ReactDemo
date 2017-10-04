using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class WorkOrder
    {
        
        public long WorkOrderId { get; set; }

        
        public byte WorkOrderTypeId { get; set; }

       
        public System.DateTime ReportedOn { get; set; }

        
        public string Title { get; set; }

        
        public string Description { get; set; }

        public byte StatusId { get; set; }

        public DateTime StatusDate { get; set; }

        public int? AgencyId { get; set; }

        
        public short DivisionId { get; set; }

        
        public int LocationId { get; set; }
        
        
        public byte PriorityId { get; set; }       

        public int? BillingAccountId { get; set; }

        public bool IsMaintenance { get; set; }

       
        public bool IsBillable { get; set; }

        
        public bool IsEmergency { get; set; }

        public DateTime? RestoredDate { get; set; }

        public long? OriginatingWO { get; set; }

        
        public string ReportedBy { get; set; }

        
        public string ReportedByPhoneNumber { get; set; }

       
        public string ReportedByEmail { get; set; }

       
        public string PointOfContact { get; set; }

       
        public string PointOfContactPhoneNumber { get; set; }

       
        public string PointOfContactEmail { get; set; }
        
        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }

        public int Id
        {
            get { return Convert.ToInt32(WorkOrderId); }
        }

        #endregion       
    }
}
