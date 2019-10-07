using System;
using System.Collections.Generic;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity.Enum;

namespace ClothShop.Core.ApplicationServices.Impl
{
    class SizeService : ISizeService
    {
        private IRepository<ClothingSize> _repo;

        public SizeService(IRepository<ClothingSize> repo)
        {
            _repo = repo;
        }

        public ClothingSize Create(ClothingSize clothingArticel)
        {
            throw new NotImplementedException();
        }

        public ClothingSize Delete(ClothingSize clothingArticel)
        {
            throw new NotImplementedException();
        }

        public ClothingSize Read(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ClothingSize> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ClothingSize Update(ClothingSize clothingArticel)
        {
            throw new NotImplementedException();
        }
    }
}
