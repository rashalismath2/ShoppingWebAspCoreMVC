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
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _dbContext.Users.Where(user => user.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await _dbContext.Users.FindAsync(userId); 
        }
    }
}
