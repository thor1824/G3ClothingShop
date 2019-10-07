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

        public ClothingArticle Create(ClothingArticle clothingArticel)
        {
            return _repo.Create(clothingArticel);
        }

        public ClothingArticle Read(int id)
        {
            return _repo.Read(id);
        }

        public List<ClothingArticle> ReadAll()
        {
            return _repo.ReadAll().ToList();
        }
        public ClothingArticle Update(ClothingArticle clothingArticel)
        {
            return _repo.Update(clothingArticel);
        }

        public ClothingArticle Delete(int id)
        {
            return _repo.Delete(Read(id));
        }

        
    }

}
