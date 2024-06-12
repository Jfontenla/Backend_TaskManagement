namespace TaskManagementApp.Domain.Entities
{
    public class OpenState : ITaskState
    {
        public void CompleteTask(Task task)
        {
            task.State = new CompletedState();
        }

        public void ReopenTask(Task task)
        {

        }
    }
}