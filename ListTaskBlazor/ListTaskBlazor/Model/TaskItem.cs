public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public TaskStatus Status { get; set; }
}

public enum TaskStatus
{
    Planned,
    Started,
    InProgress,
    Blocked,
    Completed
}