using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity.Enum;

namespace ClothShop.Core.ApplicationServices.Impl
{
    public class ColorService : IColorService
    {
        private IRepository<ClothingColor> _repo;

        public ColorService(IRepository<ClothingColor> repo)
        {
            _repo = repo;
        }

        public ClothingColor Create(ClothingColor clothingColor)
        {
            return _repo.Create(clothingColor);
        }

        public ClothingColor Delete(int id)
        {
            return _repo.Delete(Read(id));
        }

        public ClothingColor Read(int id)
        {
            return _repo.Read(id);
        }

        public List<ClothingColor> ReadAll()
        {
            return _repo.ReadAll().ToList();
        }

        public ClothingColor Update(ClothingColor clothingColor)
        {
            return _repo.Update(clothingColor);
        }
    }
}
