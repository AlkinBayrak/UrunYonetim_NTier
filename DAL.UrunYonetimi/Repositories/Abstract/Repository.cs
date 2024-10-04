using DAL.UrunYonetimi.Context;
using DAL.UrunYonetimi.Entities.Abstract;
using DAL.UrunYonetimi.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Repositories.Abstract
{
    public abstract class Repository<TEntity> :IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ProductDbContext _context;
        private DbSet<TEntity> _entities;

        protected Repository(ProductDbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
             entity.DataStatus = DataStatus.Inserted;
             entity.CreatedDate = DateTime.Now;
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            entity.DataStatus = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            Update(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities.AsNoTracking().Where(e => e.DataStatus != DataStatus.Deleted);
        }

        public TEntity GetById(int id)
        {
            return _entities.AsNoTracking().FirstOrDefault(e=>e.Id == id);
            //return _entities.FirstOrDefault(e=>e.Id == id);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> conditions)
        {
            var all = _entities.Where(e => e.DataStatus != DataStatus.Deleted);
            return all.Where(conditions);
        }

        public void Update(TEntity entity)
        {
           
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted ? DataStatus.Updated : DataStatus.Deleted;
            entity.ModifiedDate = DateTime.Now;
            entity.CreatedDate = GetById(entity.Id).CreatedDate;

            foreach (var item in _context.ChangeTracker.Entries())
            {
                if(item.Entity.GetType() == typeof(TEntity))
                {
                    item.State = EntityState.Detached;
                }
            }

            
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
