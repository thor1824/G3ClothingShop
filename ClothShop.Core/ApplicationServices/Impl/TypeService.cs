using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity.Enum;

namespace ClothShop.Core.ApplicationServices.Impl
{
    public class TypeService : ITypeService
    {
        private IRepository<ClothingType> _repo;

        public TypeService(IRepository<ClothingType> repo)
        {
            _repo = repo;
        }

        public ClothingType Create(ClothingType clothingType)
        {
            return _repo.Create(clothingType);
        }

        public ClothingType Read(int id)
        {
            return _repo.Read(id);
        }

        public List<ClothingType> ReadAll()
        {
            return _repo.ReadAll().ToList();
        }

        public ClothingType Update(ClothingType clothingType)
        {
            return _repo.Update(clothingType);
        }

        public ClothingType Delete(int id)
        {
            return _repo.Delete(Read(id));
        }
    }
}
