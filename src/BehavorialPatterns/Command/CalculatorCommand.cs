namespace BehavioralPatterns.Command;

public class CalculatorCommand : Commander
{
    private char _operator;
    private int _value;
    private readonly Calculator _calculator;

    public CalculatorCommand(Calculator calculator, char @operator, int value)
    {
        _operator = @operator;
        _value = value;
        _calculator = calculator;
    }

    public char Operator
    {
        set => _operator = value;
    }

    public int Operand
    {
        set => _value = value;
    }

    public override void Execute()
    {
        _calculator.Operation(_operator, _value);
    }

    public override void Undo()
    {
        _calculator.Operation(Undo(_operator), _value);
    }

    private static char Undo(char @operator) => @operator switch
    {
        '+' => '-',
        '-' => '+',
        '*' => '/',
        '/' => '*',
        _ => throw new ArgumentException("operator unknown")
    };
}
