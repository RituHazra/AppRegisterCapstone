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
    
    public partial class tbl_ResidentMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ResidentMaster()
        {
            this.tbl_FlatMaster = new HashSet<tbl_FlatMaster>();
            this.tbl_FlatMaster1 = new HashSet<tbl_FlatMaster>();
            this.tbl_UserRegisterMaster = new HashSet<tbl_UserRegisterMaster>();
        }
    
        public string ResidentId { get; set; }
        public string ResidentName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string FlatId { get; set; }
        public Nullable<bool> IsOwner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FlatMaster> tbl_FlatMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FlatMaster> tbl_FlatMaster1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UserRegisterMaster> tbl_UserRegisterMaster { get; set; }
    }
}
