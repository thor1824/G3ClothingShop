using System;
using System.Collections.Generic;
using System.Text;

namespace ClothShop.Core.DomainServices
{
    public interface IRepository<T>
    {
        T Create(T entity);

        T Read(int ID);

        IEnumerable<T> ReadAll();

        T Update(T enity);

        T Delete(T entity);
    }
}
