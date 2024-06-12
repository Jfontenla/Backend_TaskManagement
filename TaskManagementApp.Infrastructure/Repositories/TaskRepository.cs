using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Domain.Repositories;
using TaskManagementApp.Infrastructure.Data;

namespace TaskManagementApp.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Domain.Entities.Task task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Domain.Entities.Task task)
        {
            _context.Remove(task);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.Task>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Domain.Entities.Task> GetByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task UpdateAsync(Domain.Entities.Task task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}
