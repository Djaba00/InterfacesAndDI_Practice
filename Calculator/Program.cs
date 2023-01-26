using System;
namespace Calculator
{
    class Program
    {
        static ILogger Logger { get; set; }

        public static void Main(string[] agrs)
        {
            Logger = new Logger();

            var calculator = new Calculator(Logger);

            calculator.SumOperation();

            Console.ReadKey();
        }
    }
}
