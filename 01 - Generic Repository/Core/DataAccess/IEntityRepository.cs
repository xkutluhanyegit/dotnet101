using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity); // Veritabanına yeni bir varlık (entity) ekler.
        void Update(T entity); // Veritabanındaki mevcut bir varlığı günceller.
        void Delete(T entity); // Veritabanından bir varlık siler.
        T Get(Expression<Func<T, bool>> filter); // Filtre koşuluna uyan bir varlık getirir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // Filtre koşuluna uyan tüm varlıkları getirir.

    }
}