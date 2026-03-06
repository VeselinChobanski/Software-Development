using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterAndLoginFirst.Repository;

public interface IRepository<TEntity>
{
     List<TEntity> GetAll();
     TEntity GetById(int id);
    void Add(TEntity item);
    void Update(int id, TEntity newEntity);
    void Delete(int id);
}
