using ClothShop.Core.Entity;
using ClothShop.Core.Entity.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Infrastructure.Contexts
{
    public class ClothingContext : DbContext
    {
        public DbSet<ClothingArticle> ClothingArticles { get; set; }
        public DbSet<ClothingType> ClothingTypes { get; set; }
        public DbSet<ClothingColor> ClothingColors { get; set; }
        public DbSet<ClothingSize> ClothingSizes { get; set; }



        public ClothingContext(DbContextOptions<ClothingContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClothColor>()
                .HasKey(cc => new { cc.ClothID, cc.ColorID });
            modelBuilder.Entity<ClothColor>()
                .HasOne(cc => cc.Cloth)
                .WithMany(c => c.Color)
                .HasForeignKey(bc => bc.ClothID);

            modelBuilder.Entity<ClothColor>()
                .HasOne(po => po.Color)
                .WithMany(o => o.ClothingOfColor)
                .HasForeignKey(po => po.ColorID);

        }
    }
}
