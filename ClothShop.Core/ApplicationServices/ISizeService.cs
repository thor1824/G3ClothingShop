using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.ApplicationServices
{
    public interface ISizeService
    {
        ClothingSize Create(ClothingSize clothingArticel);

        List<ClothingSize> ReadAll();

        ClothingSize Read(int id);

        ClothingSize Update(ClothingSize clothingArticel);

        ClothingSize Delete(int id);
    }
}
