﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektAPBD_PiotrPawlaks15182
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class s15182Entities : DbContext
    {
        public s15182Entities()
            : base("name=s15182Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gosc> Gosc { get; set; }
        public virtual DbSet<Kategoria> Kategoria { get; set; }
        public virtual DbSet<Pokoj> Pokoj { get; set; }
        public virtual DbSet<Rezerwacja> Rezerwacja { get; set; }

        internal void InsertOnSubmit()
        {
            throw new NotImplementedException();
        }

        internal void SubmitChanges()
        {
            throw new NotImplementedException();
        }
    }
}