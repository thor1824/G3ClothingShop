using ClothShop.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Infrastructure.Contexts
{
    public class ClothingContext : DbContext
    {
        public DbSet<ClothingArticle> Cloths { get; set; }

        public ClothingContext(DbContextOptions<ClothingContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<PetOwner>()
            //    .HasKey(po => new { po.PetID, po.OwnerID });
            //modelBuilder.Entity<PetOwner>()
            //    .HasOne(po => po.Pet)
            //    .WithMany(p => p.PreviousOwners)
            //    .HasForeignKey(bc => bc.PetID);

            //modelBuilder.Entity<PetOwner>()
            //    .HasOne(po => po.Owner)
            //    .WithMany(o => o.PreviousOwnedPets)
            //    .HasForeignKey(po => po.OwnerID);

        }
    }
}
