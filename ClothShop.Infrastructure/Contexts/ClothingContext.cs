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

            modelBuilder.Entity<ClothColor>()
                .HasKey(cc => new { cc.ClothID, cc.ColorID });
            modelBuilder.Entity<ClothColor>()
                .HasOne(cc => cc.cloth)
                .WithMany(c => c.Color)
                .HasForeignKey(bc => bc.ClothID);

            modelBuilder.Entity<ClothColor>()
                .HasOne(po => po.Color)
                .WithMany(o => o.ClothingOfColor)
                .HasForeignKey(po => po.ColorID);

        }
    }
}
