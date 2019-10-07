using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity;
using ClothShop.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothShop.Infrastructure.Repositories
{
    

    public class ClothingRepository : IRepository<ClothingArticle>
    {
        private readonly ClothingContext _ctx;

        public ClothingRepository(ClothingContext ctx)
        {
            _ctx = ctx;
        }

        public ClothingArticle Create(ClothingArticle entity)
        {
            throw new NotImplementedException();
        }

        public ClothingArticle Delete(ClothingArticle entity)
        {
            throw new NotImplementedException();
        }

        public ClothingArticle Read(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClothingArticle> ReadAll()
        {
            return _ctx.Cloths.Include(c => c.Size).Include(c => c.Gender).Include(c => c.ClothingType).Include(c => c.Color).ThenInclude(cc => cc.Color);
        }

        public ClothingArticle Update(ClothingArticle enity)
        {
            throw new NotImplementedException();
        }
    }
}
