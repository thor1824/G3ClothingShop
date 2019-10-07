using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.ApplicationServices
{
    interface ITypeService
    {
        ClothingType Create(ClothingType clothingType);

        IList<ClothingType> ReadAll();

        ClothingType Read(int id);

        ClothingType Update(ClothingType clothingArticel);

        ClothingType Delete(ClothingType clothingArticel);
    }
}
