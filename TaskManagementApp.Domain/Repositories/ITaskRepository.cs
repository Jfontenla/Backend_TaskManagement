using TaskManagementApp.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace TaskManagementApp.Domain.Repositories
{
    public interface ITaskRepository
    {
        Task<Entities.Task> GetByIdAsync(int id);
        Task<IEnumerable<Entities.Task>> GetAllAsync();
        Task AddAsync(Entities.Task task);
        Task UpdateAsync(Entities.Task task);
        Task DeleteAsync(Entities.Task task);
    }
}
