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
    
    public partial class tbl_ApartmentMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ApartmentMaster()
        {
            this.tbl_FlatMaster = new HashSet<tbl_FlatMaster>();
        }
    
        public string ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public string Builder { get; set; }
        public Nullable<byte> Number_of_Flats { get; set; }
        public string AdminId { get; set; }
        public string Ass_Pres { get; set; }
        public string Ass_Pres_EmailId { get; set; }
        public string Ass_Sec { get; set; }
        public string Ass_Sec_EmailId { get; set; }
        public string Ass_Manager { get; set; }
        public string Ass_Manager_EmailId { get; set; }
    
        public virtual tbl_RolesMaster tbl_RolesMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FlatMaster> tbl_FlatMaster { get; set; }
    }
}
