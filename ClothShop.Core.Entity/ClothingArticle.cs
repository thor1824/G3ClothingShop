using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.Entity
{
    public class ClothingArticle
    {
        public bool HasId { get { return Id.HasValue; } }
        public int? Id { get; set; }

        public ClothingSize Size { get; set; }

        public ClothingColor Color { get; set; }

        public ClothingType ClothingType { get; set; }

        public double Price { get; set; }

        public ClothingGender Gender { get; set; }



    }
}
