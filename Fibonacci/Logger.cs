using System.Reflection;

namespace Fibonacci
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        public void Log(string message)
        {
            if (Assembly.GetEntryAssembly().GetName().Name != "Fibonacci.Console")
                throw new Exception("Expected to be running from console");

            Console.WriteLine(message);
        }
    }
}