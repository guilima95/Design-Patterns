namespace BehavioralPatterns.Command;

public class Calculator
{
    private int _currentValue;

    public void Operation(char @operator, int value)
    {
        switch (@operator)
        {
            case '+': _currentValue += value; break;
            case '-': _currentValue -= value; break;
            case '*': _currentValue *= value; break;
            case '/': _currentValue /= value; break;
        }

        Console.WriteLine("(data {1} {2}) - Current value = {0,3}", _currentValue, @operator, value);
    }
}
