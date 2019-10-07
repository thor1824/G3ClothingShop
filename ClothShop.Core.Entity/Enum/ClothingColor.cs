using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.Entity.Enum
{
    public class ClothingColor
    {
        public int id { get; set; }
        public string Color { get; set; }

        public ICollection<ClothColor> ClothingOfColor { get; set; }

    }
}
