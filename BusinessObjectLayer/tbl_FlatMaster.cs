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
    
    public partial class tbl_FlatMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FlatMaster()
        {
            this.tbl_RequestRegister = new HashSet<tbl_RequestRegister>();
        }
    
        public string FlatId { get; set; }
        public string OwnerId { get; set; }
        public Nullable<bool> IsOnRent { get; set; }
        public Nullable<bool> IsVerifiedByAdmin { get; set; }
        public Nullable<byte> FlatCategoryId { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public string OccupantId { get; set; }
        public string ApartmentId { get; set; }
    
        public virtual tbl_ApartmentMaster tbl_ApartmentMaster { get; set; }
        public virtual tbl_FlatCategoryMaster tbl_FlatCategoryMaster { get; set; }
        public virtual tbl_ResidentMaster tbl_ResidentMaster { get; set; }
        public virtual tbl_ResidentMaster tbl_ResidentMaster1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RequestRegister> tbl_RequestRegister { get; set; }
    }
}