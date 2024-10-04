using DAL.UrunYonetimi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Repositories.Abstract
{
    public interface IRepository<TEntity> 
    {
        public void Create(TEntity entity);

        public void Update(TEntity entity);

        public void Delete(TEntity entity); // Soft delete (gerçekten silmeyip, statüyü silindi yapacak)

        public void Remove(TEntity entity); // Hard delete (gerçekten silecek)

        public IQueryable<TEntity> GetAll();
        public TEntity GetById(int id);

        public IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> conditions);




    }
}
