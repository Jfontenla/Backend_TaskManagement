namespace TaskManagementApp.Domain.Entities;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public DateTime Deadline { get; set; }

    public int StatusId { get; set; }
    public int UserCreatorId { get; set; }
    public int AssignedUserId { get; set; }

    public OpenState State { get; set; }
    public ApplicationUser AssignedUser { get; set; }

    public void CompleteTask()
    {
        State.CompleteTask(this);
    }

    public void ReopenTask()
    {
        State.ReopenTask(this);
    }
}
