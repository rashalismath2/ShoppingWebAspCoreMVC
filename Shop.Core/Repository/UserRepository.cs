using Shop.Core.Models;
using Shop.Core.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Core.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(AppDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public AppDbContext DbContext { get; }

        public User GetUserByEmail(string email)
        {
            return DbContext.Users.Where(user => user.Email == email).FirstOrDefault();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await DbContext.Users.FindAsync(userId); 
        }
    }
}
