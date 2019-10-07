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
    class ColorRepository : IRepository<ClothingColor>
    {
        private readonly ClothingContext _ctx;

        public ColorRepository(ClothingContext ctx)
        {
            _ctx = ctx;
        }
        public ClothingColor Create(ClothingColor entity)
        {
            return _ctx.ClothingColors.Add(entity).Entity;
        }

        public ClothingColor Delete(ClothingColor entity)
        {
            _ctx.ClothingColors.Remove(entity).State = EntityState.Deleted;
            _ctx.SaveChanges();
            return entity;
        }

        public ClothingColor Read(int id)
        {
            return _ctx.ClothingColors
                .Include(cc => cc.ClothingOfColor)
                .ThenInclude(e => e.Cloth)
                .FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<ClothingColor> ReadAll()
        {
            return _ctx.ClothingColors
                .Include(cc => cc.ClothingOfColor)
                .ThenInclude(e => e.Cloth);
        }

        public ClothingColor Update(ClothingColor entity)
        {
            var result = Read(entity.id);
            if (result != null)
            {
                result.Color = entity.Color;
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
