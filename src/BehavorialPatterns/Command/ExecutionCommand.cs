namespace BehavioralPatterns.Command;

public static class ExecutionCommand
{
    public static void Execute()
    {
        User user = new();

        user.Add('+', 100);
        user.Add('-', 50);
        user.Add('*', 10);
        user.Add('/', 2);

        user.Undo(levels: 4);

        Console.ReadKey();

        user.Return(levels: 3);
    }
}
