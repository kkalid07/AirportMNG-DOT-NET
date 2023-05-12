using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private DbContext context;
        private Type RepositoryType;

        public UnitOfWork(DbContext context, Type repositoryType)
        {
            this.context = context;
            RepositoryType = repositoryType;
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return (IGenericRepository<TEntity>)Activator.CreateInstance(RepositoryType
                        .MakeGenericType(typeof(TEntity)), context);
        }

        public int Save()
        {
            // Save changes with the default options
            return context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue) // l'espace non liberé par context
            {
                if (disposing)
                {
                    // TODO: supprimer l'état managé (objets managés)
                }

                // TODO: libérer les ressources non managées (objets non managés) et substituer le finaliseur
                // TODO: affecter aux grands champs une valeur null
                disposedValue = true;
            }
        }

        // // TODO: substituer le finaliseur uniquement si 'Dispose(bool disposing)' a du code pour libérer les ressources non managées
        // ~UnitOfWork()
        // {
        //     // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
