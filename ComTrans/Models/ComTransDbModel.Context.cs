﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComTrans.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ComTransEntities1 : DbContext
    {
        public ComTransEntities1()
            : base("name=ComTransEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Cargo> Cargoes { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripAddress> TripAddresses { get; set; }
    }
}