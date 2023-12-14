namespace BehavioralPatterns.Command;

public class User
{
    // Inicializers
    private readonly Calculator _calculator = new();
    private readonly List<Commander> _commands = [];
    private int _total;

    // Add operator to exe calculator command
    public void Add(char @operator, int value)
    {
        Commander command = new CalculatorCommand(_calculator, @operator, value);
        command.Execute();

        _commands.Add(command);
        _total++;
    }

    // Return operation from levels
    public void Return(int levels)
    {
        Console.WriteLine("\n---- Returning {0} levels ", levels);

        for (int i = 0; i < levels; i++)
        {
            if (_total >= _commands.Count - 1)
            {
                continue;
            }

            Commander command = _commands[_total++];
            command.Execute();
        }
    }

    // Undo operation from levels
    public void Undo(int levels)
    {
        Console.WriteLine("\n---- Undoing {0} levels", levels);

        for (int i = 0; i < levels; i++)
        {
            if (_total <= 0)
            {
                continue;
            }

            Commander command = _commands[--_total];
            command.Undo();
        }
    }

}
