using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity;
using ClothShop.Core.ApplicationServices;

namespace ClothShop.Core.ApplicationServices.Impl
{
    public class ClothService : IClothService
    {
        private IRepository<ClothingArticle> _repo;

        public ClothService(IRepository<ClothingArticle> ClothRepo)
        {
            _repo = ClothRepo;
        }

        public List<ClothingArticle> ReadAll()
        {
            return _repo.ReadAll().ToList();
        }
        

        public ClothingArticle Create(ClothingArticle cloth)
        {
            throw new NotImplementedException();
        }


        public  ClothingArticle Read(int id)
        {
            throw new NotImplementedException();
        }

        public ClothingArticle Delete(ClothingArticle cloth)
        {
            throw new NotImplementedException();
        }

        public ClothingArticle Update(ClothingArticle cloth)
        {
            throw new NotImplementedException();
        }
    }

}
