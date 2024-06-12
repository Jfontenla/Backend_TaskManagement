using TaskManagementApp.Domain.Repositories;

namespace TaskManagementApp.Application.Services;

public class TaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<IEnumerable<Domain.Entities.Task>> GetTasksAsync()
    {
        return await _taskRepository.GetAllAsync();
    }

    public async Task<Domain.Entities.Task> GetTaskAsync(int id)
    {
        return await _taskRepository.GetByIdAsync(id);
    }

    public async Task CreateTaskAsync(Domain.Entities.Task task)
    {
        await _taskRepository.AddAsync(task);
    }

    public async Task UpdateTaskAsync(Domain.Entities.Task task)
    {
        await _taskRepository.UpdateAsync(task);
    }

    public async Task DeleteAsync(int id)
    {
        var task = await _taskRepository.GetByIdAsync(id);

        if (task != null)
        {
            await _taskRepository.DeleteAsync(task); 
        }
    }
}
