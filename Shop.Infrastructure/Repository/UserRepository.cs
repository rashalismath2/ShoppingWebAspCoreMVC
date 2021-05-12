using Microsoft.EntityFrameworkCore;
using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(AppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }

        public async Task<User> GetUserByEmail(string email)
        {
            return await DbContext.Users.Where(user => user.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await DbContext.Users.FindAsync(userId); 
        }
    }
}
