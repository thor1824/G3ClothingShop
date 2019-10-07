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
    class TypeRepository : IRepository<ClothingType>
    {
        private readonly ClothingContext _ctx;

        public TypeRepository(ClothingContext ctx)
        {
            _ctx = ctx;
        }

        public ClothingType Create(ClothingType entity)
        {
            return _ctx.ClothingTypes.Add(entity).Entity;
        }

        public ClothingType Delete(ClothingType entity)
        {
            _ctx.ClothingTypes.Remove(entity).State = EntityState.Deleted;
            _ctx.SaveChanges();
            return entity;
        }

        public ClothingType Read(int id)
        {
            return _ctx.ClothingTypes
                .FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<ClothingType> ReadAll()
        {
            return _ctx.ClothingTypes;
        }

        public ClothingType Update(ClothingType entity)
        {
            var result = Read(entity.id);
            if (result != null)
            {
                result.CType = entity.CType;
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
