namespace Fibonacci
{
    public class FibonacciCalculator
    {
        /// <summary>Calculate the nth fibonaci number (sum of the previous two numbers)</summary>
        //  IN: 1   2   3   4   5    6    7    8    9   10     20          40
        // OUT: 1   1   2   3   5    8   13   21   34   55   6765   102334155
        public int GetFibonacciNumber(int n)
        {
            var result = CalculateFibonacci(n);
            new Logger().Log($"fibonacci {n} is {result}");
            return result;
        }

        private static int CalculateFibonacci(int n)
        {
            return n <= 2 ? 1 : CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}
