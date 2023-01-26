using System;
namespace Calculator
{
	public class Logger : ILogger
	{
        public void Event(string message)
        {
            Console.WriteLine(message);
        }
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

