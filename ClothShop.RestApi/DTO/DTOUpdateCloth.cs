using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothShop.RestApi.DTO
{
    public class DTOUpdateCloth
    {
        public int size { get; set; }

        public int[] colors { get; set; }

        public int ClothingType { get; set; }

        public double Price { get; set; }

        public int Gender { get; set; }

        public string ImageUrl { get; set; }
    }
}
