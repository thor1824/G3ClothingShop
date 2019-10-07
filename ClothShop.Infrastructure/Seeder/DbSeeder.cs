using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ClothShop.Core.Entity;
using ClothShop.Core.Entity.Enum;
using ClothShop.Infrastructure.Contexts;

namespace ClothShop.Infrastructure.Seeder
{
    public class DbSeeder
    {
        public static void Seed(ClothingContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            //CT
            ClothingType ct1 = new ClothingType() {CType = "T-Shirt"};
            ClothingType ct2 = new ClothingType() {CType = "Jacket"};
            ClothingType ct3 = new ClothingType() { CType = "Hoodie" };
            //Size
            ClothingSize cs1 = new ClothingSize() {Size = "XLarge" };
            ClothingSize cs2 = new ClothingSize() { Size = "Large" };
            ClothingSize cs3 = new ClothingSize() { Size = "Medium" };
            //Color
            ClothingColor cc1 = new ClothingColor() {Color = "Black" };
            ClothingColor cc2 = new ClothingColor() { Color = "White" };
            ClothingColor cc3 = new ClothingColor() { Color = "Green" };

            ClothingArticle cloth1 = new ClothingArticle()
            {
                ClothingType = ct1,
                Size = cs1,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc1
                    }
                },
                Gender = ClothingGender.Male,
                Price = 350
            };
            ClothingArticle cloth2 = new ClothingArticle()
            {
                ClothingType = ct1,
                Size = cs2,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc2
                    }
                },
                Gender = ClothingGender.Male,
                Price = 250
            };
            ClothingArticle cloth3 = new ClothingArticle()
            {
                ClothingType = ct1,
                Size = cs1,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc3
                    }
                },
                Gender = ClothingGender.Male,
                Price = 200
            };
            ClothingArticle cloth4 = new ClothingArticle()
            {
                ClothingType = ct2,
                Size = cs1,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc1
                    }
                },
                Gender = ClothingGender.Male,
                Price = 300
            };
            ClothingArticle cloth5 = new ClothingArticle()
            {
                ClothingType = ct2,
                Size = cs2,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc1
                    }
                },
                Gender = ClothingGender.Male,
                Price = 500
            };
            ClothingArticle cloth6 = new ClothingArticle()
            {
                ClothingType = ct2,
                Size = cs3,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc1
                    }
                },
                Gender = ClothingGender.Unisex,
                Price = 400
            };
            ClothingArticle cloth7 = new ClothingArticle()
            {
                ClothingType = ct3,
                Size = cs1,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc1
                    }
                },
                Gender = ClothingGender.Male,
                Price = 200
            };
            ClothingArticle cloth8 = new ClothingArticle()
            {
                ClothingType = ct3,
                Size = cs1,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc2
                    }
                },
                Gender = ClothingGender.Female,
                Price = 600
            };
            ClothingArticle cloth9 = new ClothingArticle()
            {
                ClothingType = ct3,
                Size = cs1,
                Color = new List<ClothColor>()
                {
                    new ClothColor()
                    {
                        Color = cc1
                    }
                },
                Gender = ClothingGender.Unisex,
                Price = 550
            };

            ctx.Add(cloth1);
            ctx.Add(cloth2);
            ctx.Add(cloth3);
            ctx.Add(cloth4);
            ctx.Add(cloth5);
            ctx.Add(cloth6);
            ctx.Add(cloth7);
            ctx.Add(cloth8);
            ctx.Add(cloth9);
            ctx.SaveChanges();


        }
    }
}
