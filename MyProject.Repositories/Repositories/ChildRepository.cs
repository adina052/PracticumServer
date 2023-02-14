using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository:IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child child)
        {
            var add = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return add.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.Include(e => e.Parent1).Include(e => e.Parent2).ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.Include(e => e.Parent1).Include(e => e.Parent2).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var updataChild = _context.Children.Update(child).Entity;
            await _context.SaveChangesAsync();
            return updataChild;
        }
    }
}
