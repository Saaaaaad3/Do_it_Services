
using Doit.Core.Application.Interfaces.Repository.User;
using Doit.Core.Entities;
using Doit.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Infrastructure.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;
        public UserRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<long?> Login(UserEntity userDbReq)
        {
            long? existingUserId = await _context.Users.Where(u => u.Username == userDbReq.Username && u.Password == userDbReq.Password).Select(user=>user.UserId).FirstOrDefaultAsync();

            if (existingUserId == null)
            {
                return null;
            }
            return existingUserId;
        }

        public async Task<int> Register(UserEntity userDbReq)
        {
            bool existingUsername = await _context.Users.AnyAsync(u => u.Username == userDbReq.Username);
            if(existingUsername)
            {
                return 0;
            }
            await _context.AddAsync(userDbReq);
            await _context.SaveChangesAsync();
            return 200;
        }
    }
}
