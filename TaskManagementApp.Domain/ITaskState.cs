using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Domain
{
    public interface ITaskState
    {
        void CompleteTask(Entities.Task task);
        void ReopenTask(Entities.Task task);
    }
}
