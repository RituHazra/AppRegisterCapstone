﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApartmentRegister_DBEntities : DbContext
    {
        public ApartmentRegister_DBEntities()
            : base("name=ApartmentRegister_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_ApartmentMaster> tbl_ApartmentMaster { get; set; }
        public virtual DbSet<tbl_FlatCategoryMaster> tbl_FlatCategoryMaster { get; set; }
        public virtual DbSet<tbl_FlatMaster> tbl_FlatMaster { get; set; }
        public virtual DbSet<tbl_RequestRegister> tbl_RequestRegister { get; set; }
        public virtual DbSet<tbl_RequestStatusMaster> tbl_RequestStatusMaster { get; set; }
        public virtual DbSet<tbl_RequestTypeMaster> tbl_RequestTypeMaster { get; set; }
        public virtual DbSet<tbl_ResidentMaster> tbl_ResidentMaster { get; set; }
        public virtual DbSet<tbl_RolesMaster> tbl_RolesMaster { get; set; }
        public virtual DbSet<tbl_UserRegisterMaster> tbl_UserRegisterMaster { get; set; }
    }
}
