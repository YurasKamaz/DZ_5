namespace Lib;

public enum Status {progress, complete}

public delegate void Delegate(string name);

public class Task
{
    public string? Name;
    public string? Description;
    public Status Status;
    public Delegate? Delegate;

    public Task(string name, string description) {
        Name = name;
        Description = description;
        Status = Status.progress;
    }
}
