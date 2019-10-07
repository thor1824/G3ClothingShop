using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity;

namespace ClothShop.Core.ApplicationServices.Impl
{
    public class ClothService
    {
        private IRepository<ClothingArticle> _repo;

        public ClothService(IRepository<ClothingArticle> ClothRepo)
        {
            _repo = ClothRepo;
        }
        public void Create(ClothingArticle createCloth)
        {

        }

        public List<ClothingArticle> ReadAll(ClothingArticle readAllCloth)
        {
            return _repo.ReadAll().ToList();
        }
        public void Read (int id)
        {

        }

        public void Update(ClothingArticle updateCloth)
        {
            
        }

        public void Delete(ClothingArticle deleteCloth)
        {

        }
    }

}
