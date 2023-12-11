using LayersArchDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchDemo.DAL.Interfaces
{
    public interface IRepositoryBase<TKey, TEntity>
    {
       IEnumerable<TEntity> GetAll();

        TEntity? GetUserId(TKey id);

        TEntity Create(TEntity enttity);

        bool Update(TEntity entity, TKey id);

        bool Delete(TKey id);
    }
}
