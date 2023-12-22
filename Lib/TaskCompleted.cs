namespace Lib;

public class TaskCompletedSystem {
    public static void TaskCompletedNotification(string name) => Console.WriteLine($"System {name} complete");
}

public class TaskCompletedUser {
    public static void TaskCompletedNotification(string name) => Console.WriteLine($"User {name} complete");
}