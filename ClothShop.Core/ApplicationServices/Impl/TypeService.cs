using System;
using System.Collections.Generic;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity.Enum;

namespace ClothShop.Core.ApplicationServices.Impl
{
    class TypeService : ITypeService
    {
        private IRepository<ClothingType> _repo;

        public TypeService(IRepository<ClothingType> repo)
        {
            _repo = repo;
        }

        public ClothingType Create(ClothingType clothingType)
        {
            throw new NotImplementedException();
        }

        public ClothingType Delete(ClothingType clothingArticel)
        {
            throw new NotImplementedException();
        }

        public ClothingType Read(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ClothingType> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ClothingType Update(ClothingType clothingArticel)
        {
            throw new NotImplementedException();
        }
    }
}
