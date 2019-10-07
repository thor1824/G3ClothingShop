using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.ApplicationServices
{
    interface ITypeService
    {
        ClothingColor Create(ClothingColor clothingArticel);

        IList<ClothingColor> ReadAll();

        ClothingColor Read(int id);

        ClothingColor Update(ClothingColor clothingArticel);

        ClothingColor Delete(ClothingColor clothingArticel);
    }
}
