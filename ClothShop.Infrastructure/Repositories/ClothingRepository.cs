﻿using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Infrastructure.Repositories
{

    public class ClothingRepository : IRepository<ClothingArticle>
    {
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
            throw new NotImplementedException();
        }

        public ClothingArticle Update(ClothingArticle enity)
        {
            throw new NotImplementedException();
        }
    }
}
