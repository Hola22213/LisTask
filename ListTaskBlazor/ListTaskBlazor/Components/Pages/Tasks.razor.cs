using System.Collections.Generic;
using System.Linq;
@rendermode InteractiveServer;
public class TaskManager
{
    private List<TaskItem> tasks = new List<TaskItem>();
    private int currentId = 1;

    public TaskManager()
    {
        AddTask("Tarea 1", TaskStatus.Planned);
        AddTask("Tarea 2", TaskStatus.Started);
    }

    public List<TaskItem> GetAllTasks()
    {
        return tasks;
    }

    public void AddTask(string title, TaskStatus status)
    {
        tasks.Add(new TaskItem { Id = currentId++, Title = title, Status = status });
    }

    public void DeleteTask(int id)
    {
        var taskToRemove = tasks.FirstOrDefault(t => t.Id == id);
        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
        }
    }

    public void ChangeTaskStatus(int id, TaskStatus newStatus)
    {
        var taskToUpdate = tasks.FirstOrDefault(t => t.Id == id);
        if (taskToUpdate != null)
        {
            taskToUpdate.Status = newStatus;
        }
    }
}
