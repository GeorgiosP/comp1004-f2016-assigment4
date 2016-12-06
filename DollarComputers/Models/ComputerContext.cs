﻿namespace DollarComputers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    /*
 * Assignment 4 Dollar Computers
 * Georgios Psarakis
 * December 5th 2016
 * 200289922 
 */
    public partial class ComputerContext : DbContext
    {
        public ComputerContext()
            : base("name=ComputerConnection")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
