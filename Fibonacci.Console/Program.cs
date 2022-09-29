using Fibonacci;

Console.WriteLine("Enter a number to get the corresponding fibonacci number, empty or q to quit");

while (true)
{
    var input = Console.ReadLine();
    if (input == "" || input == "q")
        break;

    var isNumber = int.TryParse(input, out var number);
    if (!isNumber)
    {
        Console.WriteLine("input must be a number");
        continue;
    }

    var fibonacciResult = new FibonacciCalculator().GetFibonacciNumber(number);
}