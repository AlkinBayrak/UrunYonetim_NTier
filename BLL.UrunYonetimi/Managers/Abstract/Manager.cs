using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DAL.UrunYonetimi.Context;
using DAL.UrunYonetimi.Entities.Abstract;
using DAL.UrunYonetimi.Enums;
using DAL.UrunYonetimi.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UrunYonetimi.Managers.Abstract
{
    public abstract class Manager<TModel,TEntity> : IManager<TModel> where TModel : class
    {
        private IMapper _mapper;
        protected IRepository<TEntity> _repository;
        protected MapperConfiguration _config;

        protected Manager()
        {
            _config = new MapperConfiguration(cfg => cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap());

            _mapper = new Mapper(_config);
        }

        public void Create(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Create(entity);
        }

        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Delete(entity);
        }

        public List<TModel> GetAll()
        {
            IQueryable<TEntity> entities = _repository.GetAll();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public TModel GetById(int id)
        {
            var entity = _repository.GetById(id);
            var model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Remove(TModel model)
        {
            var entity = _mapper.Map<TEntity>(model);

            _repository.Remove(entity);
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> conditions)
        {
            var predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(conditions);

            var entities = _repository.Search(predicate).ToList();

            var models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Update(entity);
        }
    }
}
