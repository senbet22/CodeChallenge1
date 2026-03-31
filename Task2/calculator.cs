// Methods : Add, Subtract, Multiply, Divide. 

public class Calculator
{
    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return double.NaN;
        }
        return Math.Round(a / b, 2);
    }

    public bool IsValidNumber(string input, out double result)
    {
        return double.TryParse(input, out result);
    }
};

