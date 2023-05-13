using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Sincro.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class UserService : IUserService
    {
        private readonly SincroDBContext _context;
        public UserService(SincroDBContext context)
        {
            _context = context;
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public List<User> GetUserWithRelations()
        {
            var listUSers = _context.Users.Include(r => r.Relations).ThenInclude(t => t.Table).ToList();
            return listUSers;
        }
    }
}
