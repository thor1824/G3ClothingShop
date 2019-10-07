using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ClothShop.Core.Entity;

namespace ClothShop.Core.ApplicationServices
{
    public interface IClothService
    {
        ClothingArticle Create(ClothingArticle clothingArticel);

        List<ClothingArticle> ReadAll();

        ClothingArticle Read(int id);

        ClothingArticle Update(ClothingArticle clothingArticel);

        ClothingArticle Delete(int id);
    }
}
