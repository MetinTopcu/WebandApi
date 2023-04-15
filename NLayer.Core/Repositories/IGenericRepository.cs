using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class //EF Core Class'lar ile çalıştığı için where T: class
    {
        // Generic Repository Pattern; veritabanı ile modeller arası köprü görevi görür CRUD yapar.
        // hiçbir yere tanımlamadık nasıl aktif oluyor bilmiyorum
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        
    }
}
