namespace Interfaces
{
    public interface InterfaceBase<in TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task AddAsync(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
