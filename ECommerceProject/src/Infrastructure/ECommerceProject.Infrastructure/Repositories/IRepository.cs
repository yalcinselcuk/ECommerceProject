using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T? Get(int id);
        IList<T?> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<T?> GetAsync(int id);
        Task<IList<T?>> GetAllAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> IsExistsAsync(int id);
    }
}
