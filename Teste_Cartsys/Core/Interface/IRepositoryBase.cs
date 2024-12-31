using System.Threading.Tasks;

namespace Core.Interface.Repository
{
    public interface IRepositoryBase<in TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task AddAsync(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
