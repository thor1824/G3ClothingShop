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

        IList<ClothingArticle> ReadAll();

        ClothingArticle Read(int id);

        ClothingArticle Update(ClothingArticle clothingArticel);

        ClothingArticle Delete(ClothingArticle clothingArticel);
    }
}
