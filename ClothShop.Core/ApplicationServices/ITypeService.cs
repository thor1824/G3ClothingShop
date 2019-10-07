using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.ApplicationServices
{
    public interface ITypeService
    {
        ClothingType Create(ClothingType clothingType);

        List<ClothingType> ReadAll();

        ClothingType Read(int id);

        ClothingType Update(ClothingType clothingArticel);

        ClothingType Delete(int id);
    }
}
