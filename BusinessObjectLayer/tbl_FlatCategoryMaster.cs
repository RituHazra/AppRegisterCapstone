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
    
    public partial class tbl_FlatCategoryMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FlatCategoryMaster()
        {
            this.tbl_FlatMaster = new HashSet<tbl_FlatMaster>();
        }
    
        public byte FlatCategoryId { get; set; }
        public string FlatCategory { get; set; }
        public Nullable<int> AreaInSqft { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FlatMaster> tbl_FlatMaster { get; set; }
    }
}
