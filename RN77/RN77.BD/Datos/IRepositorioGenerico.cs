using System.Linq;
using System.Threading.Tasks;

namespace RN77.BD.Datos
{
    public interface IRepositorioGenerico<T> where T : class, IEntityBase
    {
        Task<T> CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> ExistAsync(int id);
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<bool> SaveAllAsync();
        Task<T> UpdateAsync(T entity);
    }
}