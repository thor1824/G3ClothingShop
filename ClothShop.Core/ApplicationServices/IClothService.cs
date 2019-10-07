using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ClothShop.Core.Entity;

namespace ClothShop.Core.ApplicationServices
{
    public interface IClothService
    {
        ClothingArticle Create(ClothingArticle cloth);

        List<ClothingArticle> ReadAll();

        ClothingArticle Read(int id);

        ClothingArticle Delete(ClothingArticle cloth);

        ClothingArticle Update(ClothingArticle cloth);




    }
}
