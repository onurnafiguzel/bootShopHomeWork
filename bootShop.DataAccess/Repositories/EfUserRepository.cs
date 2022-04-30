using bootShop.DataAccess.Data;
using bootShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Repositories
{
    public class EfUserRepository : IUserRepository
    {
        private readonly bootShopDbContext context;

        public EfUserRepository(bootShopDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Add(User entity)
        {
            await context.Users.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }

        public async Task<IList<User>> GetAllEntities()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetEntityById(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<bool> IsExists(int id)
        {
            return await context.Users.AnyAsync(u => u.Id == id);
        }

        public async Task<int> Update(User entity)
        {
            context.Users.Add(entity);
            return await context.SaveChangesAsync();
        }

        public User ValidateUser(string userName, string password)
        {
            return context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }
}
