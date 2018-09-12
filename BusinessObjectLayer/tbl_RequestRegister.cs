//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjectLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_RequestRegister
    {
        public string RequestId { get; set; }
        public string RequestTypeId { get; set; }
        public string RequestStatusId { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsExternalVendorRequired { get; set; }
        public string VendorName { get; set; }
        public string VendorContactNumber { get; set; }
        public string VendorRole { get; set; }
        public Nullable<bool> IsApprovedByAdmin { get; set; }
        public string RejectionReason { get; set; }
        public Nullable<bool> IsUrgent { get; set; }
        public string FlatId { get; set; }
    
        public virtual tbl_FlatMaster tbl_FlatMaster { get; set; }
        public virtual tbl_RequestStatusMaster tbl_RequestStatusMaster { get; set; }
        public virtual tbl_RequestTypeMaster tbl_RequestTypeMaster { get; set; }
    }
}