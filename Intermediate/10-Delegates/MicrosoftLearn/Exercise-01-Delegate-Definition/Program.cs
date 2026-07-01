// Define a delegate type
public delegate int PerformCalculation(int x, int y);

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public int Divide(int x, int y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        return x / y;
    }
}

public class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Create delegate instances
        PerformCalculation add = new PerformCalculation(calculator.Add);
        PerformCalculation subtract = new PerformCalculation(calculator.Subtract);
        PerformCalculation multiply = new PerformCalculation(calculator.Multiply);
        PerformCalculation divide = new PerformCalculation(calculator.Divide);

        // Call the method using delegates
        Console.WriteLine($"Addition: {add(5, 3)}"); // Output: 8
        Console.WriteLine($"Subtraction: {subtract(5, 3)}"); // Output: 2
        Console.WriteLine($"Multiplication: {multiply(5, 3)}"); // Output: 15
        Console.WriteLine($"Division: {divide(5, 3)}"); // Output: 1
    }
}