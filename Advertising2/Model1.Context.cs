﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Advertising2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class advertisingEntities : DbContext
    {
        public advertisingEntities()
            : base("name=advertisingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdvertisingsSet> AdvertisingsSet { get; set; }
        public virtual DbSet<NewspaperSet> NewspaperSet { get; set; }
        public virtual DbSet<OrganizationsSet> OrganizationsSet { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
