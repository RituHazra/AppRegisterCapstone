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
    
    public partial class tbl_RequestTypeMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_RequestTypeMaster()
        {
            this.tbl_RequestRegister = new HashSet<tbl_RequestRegister>();
        }
    
        public string RequestTypeId { get; set; }
        public string RequestTypeDesc { get; set; }
        public Nullable<byte> SLA_in_hours { get; set; }
        public Nullable<bool> IsChargeable { get; set; }
        public Nullable<decimal> Charges { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RequestRegister> tbl_RequestRegister { get; set; }
    }
}