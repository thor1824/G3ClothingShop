using ClothShop.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.Entity
{
    public class ClothColor
    {
        public int ColorID { get; set; }
        public ClothingColor Color { get; set; }
        public int ClothID { get; set; }
        public ClothingArticle cloth { get; set; }
        

    }
}
