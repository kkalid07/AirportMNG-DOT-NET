using System.Linq.Expressions;

namespace AM.ApplicationCore.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> condition); // supprimer avec condition
        TEntity GetById(params object[] keyValues); // n'importe quel type d'objet dans le parametre
        TEntity Get(Expression<Func<TEntity, bool>> condition);
        IEnumerable<TEntity> GetAll(); // GetMany()
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where = null);
        void SubmitChanges();
    }
}
