using Lib;
using Task = Lib.Task;

Task task_1 = TaskManager.CreateTask("111", "descr");
Task task_2 = TaskManager.CreateTask("222", "descr");
Task task_3 = TaskManager.CreateTask("333", "descr");

TaskManager.Print();
Console.WriteLine();

TaskManager.UpdateTask(task_1, "444", "rcsed");

TaskManager.Print();
Console.WriteLine();

task_1.Delegate += TaskCompletedSystem.TaskCompletedNotification;

task_2.Delegate += TaskCompletedUser.TaskCompletedNotification;

task_3.Delegate += TaskCompletedSystem.TaskCompletedNotification;
task_3.Delegate += TaskCompletedUser.TaskCompletedNotification;

foreach (Task task in TaskManager.Tasks.ToArray()) {
    TaskManager.CompleteTask(task);
    TaskManager.RemoveTask(task);
}