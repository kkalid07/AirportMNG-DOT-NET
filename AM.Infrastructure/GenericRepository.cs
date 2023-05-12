using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private Microsoft.EntityFrameworkCore.DbContext context;
        private Microsoft.EntityFrameworkCore.DbSet<TEntity> entities;
        private UnitOfWork unitOfWork;

        public GenericRepository(Microsoft.EntityFrameworkCore.DbContext dB)
        {
            context = dB;
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> condition)
        {
            entities.RemoveRange(entities.Where(condition));
        }

        public TEntity Get(Expression<Func<TEntity, bool>> condition)
        {
            return entities.Where(condition).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.AsEnumerable();
        }

        public TEntity GetById(params object[] keyValues)
        {
            return entities.Find(keyValues);
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> condition = null)
        {
            if(condition != null)
                return entities.Where(condition).AsEnumerable();
            return entities.AsEnumerable();
        }

        public void SubmitChanges()
        {
            unitOfWork.Save();
        }

        public void Update(TEntity entity)
        {
            entities.Update(entity);
        }

    }
}
