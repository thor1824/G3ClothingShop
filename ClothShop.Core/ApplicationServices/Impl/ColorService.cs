using System;
using System.Collections.Generic;
using System.Text;
using ClothShop.Core.Entity.Enum;

namespace ClothShop.Core.ApplicationServices.Impl
{
    class ColorService : IColorService
    {
        private IRepository<ClothingColor> _repo;

        public ColorService(IRepository<ClothingColor> repo)
        {
            _repo = repo;
        }

        public ClothingColor Create(ClothingColor clothingArticel)
        {
            throw new NotImplementedException();
        }

        public ClothingColor Delete(ClothingColor clothingArticel)
        {
            throw new NotImplementedException();
        }

        public ClothingColor Read(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ClothingColor> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ClothingColor Update(ClothingColor clothingArticel)
        {
            throw new NotImplementedException();
        }
    }
}
