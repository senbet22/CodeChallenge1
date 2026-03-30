

Calculator calculator = new Calculator();


Console.WriteLine("Welcome to Simple Calculator!");
Console.WriteLine("Please enter your first number:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your second number:");
double b = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Choose your operation: A to add, S to subtract, M to multiply or D to Devide");
string operation = Console.ReadLine().ToUpper();


double result;

switch (operation) 
{ 
    case "A":
        result = calculator.Add(a, b);
        Console.WriteLine($"Result: {result}");
        break;
    case "S":
        result = calculator.Subtract(a, b);
        Console.WriteLine($"Result: {result}");
        break;
    case "M":
        result = calculator.Multiply(a, b);
        Console.WriteLine($"Result: {result}");
        break;
    case "D":
        result = calculator.Divide(a, b);
        Console.WriteLine($"result: {result}");
        break;
    default:
        Console.WriteLine("Invalid Operation.");
        break;
}




