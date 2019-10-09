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
            var newEntity = _ctx.ClothingArticles.Add(entity).Entity;
            _ctx.SaveChanges();
            return newEntity;
        }

        public ClothingArticle Delete(ClothingArticle entity)
        {
            _ctx.ClothingArticles.Remove(entity).State = EntityState.Deleted;
            _ctx.SaveChanges();
            return entity;
        }

        public ClothingArticle Read(int id)
        {
            return _ctx.ClothingArticles
                .Include(c => c.Size)
                .Include(c => c.ClothingType)
                .Include(c => c.Color).ThenInclude(cc => cc.Color)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ClothingArticle> ReadAll()
        {
            return _ctx.ClothingArticles
                .Include(c => c.Size)
                .Include(c => c.ClothingType)
                .Include(c => c.Color).ThenInclude(cc => cc.Color);
        }

        public ClothingArticle Update(ClothingArticle entity)
        {
            var result = Read(entity.Id.Value);
            if (result != null)
            {
                result.Size = entity.Size;
                result.Color = entity.Color;
                result.ClothingType = entity.ClothingType;
                result.Price = entity.Price;
                result.Color = entity.Color;
                result.Gender = entity.Gender;
                result.ImageUrl = entity.ImageUrl;
                _ctx.SaveChanges();
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
