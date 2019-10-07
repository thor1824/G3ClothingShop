using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.ApplicationServices
{
    public interface IColorService
    {
        ClothingColor Create(ClothingColor clothingArticel);

        List<ClothingColor> ReadAll();

        ClothingColor Read(int id);

        ClothingColor Update(ClothingColor clothingArticel);

        ClothingColor Delete(int id);
    }
}
