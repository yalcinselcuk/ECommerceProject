using ECommerceProject.Entities;
using ECommerceProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Infrastructure.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly ECommerceDbContext dbContext;

        public EFUserRepository(ECommerceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(User entity)
        {
            dbContext.Users.Add(entity);
            dbContext.SaveChanges();
        }

        public async Task CreateAsync(User entity)
        {
            await dbContext.Users.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public void Delete(User entity)
        {
            var deleteingUser = dbContext.Users.Find(entity.Id);
            dbContext.Users.Remove(deleteingUser);
            dbContext.SaveChanges();
        }

        public async Task DeleteAsync(User entity)
        {
            var deletingUser = await dbContext.Users.FindAsync(entity.Id);
            dbContext.Users.Remove(deletingUser);
            await dbContext.SaveChangesAsync();
        }

        public User? Get(int id)
        {
            return dbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public IList<User?> GetAll()
        {
            return dbContext.Users.AsNoTracking().ToList();
        }

        public async Task<IList<User?>> GetAllAsync()
        {
            return await dbContext.Users.AsNoTracking().ToListAsync();  
        }

        public async Task<User?> GetAsync(int id)
        {
            return await dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await dbContext.Users.AnyAsync(u => u.Id == id);
        }

        public void Update(User entity)
        {
            dbContext.Users.Update(entity);
            dbContext.SaveChanges();
        }

        public async Task UpdateAsync(User entity)
        {
            dbContext.Users.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
