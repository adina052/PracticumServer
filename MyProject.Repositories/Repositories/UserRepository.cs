using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> AddAsync(User user)
        {
            var add= _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return add.Entity;

           
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(await GetByIdAsync(id));
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync();
        }

        public async Task<User> UpdateAsync(User user)
        {
            var updataUser = _context.Users.Update(user).Entity;
            await _context.SaveChangesAsync();
            return updataUser;
        }
    }
}
