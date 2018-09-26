using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Petshop.Core.Entity;

namespace Petshop.Infrastructure.Data
{
    public class PetAppContext : DbContext
    {

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public PetAppContext(DbContextOptions<PetAppContext> opt) : base(opt)
        {



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasOne((p => p.PreviousOwner))
                .WithMany(o => o.PetsList)
                .OnDelete(DeleteBehavior.SetNull);



        }


    }
}

