﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sehirTanitimi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sehirBilgiEntities : DbContext
    {
        public sehirBilgiEntities()
            : base("name=sehirBilgiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolgeler> Bolgelers { get; set; }
        public virtual DbSet<Iller> Illers { get; set; }
        public virtual DbSet<Nufu> Nufus { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
    }
}
