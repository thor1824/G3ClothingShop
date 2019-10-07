using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity.Enum;

namespace ClothShop.Core.ApplicationServices.Impl
{
    public class SizeService : ISizeService
    {
        private IRepository<ClothingSize> _repo;

        public SizeService(IRepository<ClothingSize> repo)
        {
            _repo = repo;
        }

        public ClothingSize Create(ClothingSize clothingSize)
        {
            return _repo.Create(clothingSize);
        }

        public ClothingSize Read(int id)
        {
            return _repo.Read(id);
        }

        public List<ClothingSize> ReadAll()
        {
            return _repo.ReadAll().ToList();
        }

        public ClothingSize Update(ClothingSize clothingSize)
        {
            return _repo.Update(clothingSize);
        }
        public ClothingSize Delete(int id)
        {
            return _repo.Delete(Read(id));
        }
    }
}
