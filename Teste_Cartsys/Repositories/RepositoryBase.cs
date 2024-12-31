using Core.Interface.Repository;

namespace Repositories
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly Data.SqlContext _context;

        protected RepositoryBase(Data.SqlContext context)
        {
            _context = context;
        }

        public virtual void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task AddAsync(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public virtual void Delete(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();

            }
            catch
            {
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual void Update(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Update(obj);
                _context.SaveChanges();

            }
            catch
            {
                throw;
            }
        }
    }
}
