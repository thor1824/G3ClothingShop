using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity.Enum;
using ClothShop.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothShop.Infrastructure.Repositories
{
    class SizeRepository : IRepository<ClothingSize>
    {
        private readonly ClothingContext _ctx;

        public SizeRepository(ClothingContext ctx)
        {
            _ctx = ctx;
        }

        public ClothingSize Create(ClothingSize entity)
        {
            return _ctx.ClothingSizes.Add(entity).Entity;
        }

        public ClothingSize Delete(ClothingSize entity)
        {
            _ctx.ClothingSizes.Remove(entity).State = EntityState.Deleted;
            _ctx.SaveChanges();
            return entity;
        }

        public ClothingSize Read(int id)
        {
            return _ctx.ClothingSizes
                .FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<ClothingSize> ReadAll()
        {
            return _ctx.ClothingSizes;
        }

        public ClothingSize Update(ClothingSize entity)
        {
            var result = Read(entity.id);
            if (result != null)
            {
                result.Size = entity.Size;
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
