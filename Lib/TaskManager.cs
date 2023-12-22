namespace Lib;

public class TaskManager {
    public static List<Task> Tasks = new List<Task>();

    public static Task CreateTask(string name, string description) {
        Task res = new Task(name, description);
        Tasks.Add(res);
        return res;
    }

    public static void RemoveTask(Task task) => Tasks.Remove(task);

    public static void UpdateTask(Task task, string newName, string newDescr) {
        task.Name = newName;
        task.Description = newDescr;
    }

    public static void CompleteTask(Task task) {
        task.Status = Status.complete;
        task.Delegate!.Invoke(task.Name!);
    }

    public static void Print() {
        foreach(var task in Tasks) Console.WriteLine($"Name {task.Name} Description {task.Description}");
    }
}