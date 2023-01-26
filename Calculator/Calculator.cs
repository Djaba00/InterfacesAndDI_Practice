using System;
namespace Calculator
{
    public class Calculator : ISumOperation
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public void SumOperation()
		{
            try
            {
                bool valid = true;
                Console.Write("x = ");
                double x = 0;
                valid = Double.TryParse(Console.ReadLine(), out x);
                Check(valid);

                Console.Write("y = ");
                double y = 0;
                valid = Double.TryParse(Console.ReadLine(), out y);
                Check(valid);

                var result = x + y;
                Console.WriteLine($"Result: {result}");

                Logger.Event("Sum complete!");
            }

            catch (Exception ex)
            {
                Logger?.Error(ex.Message);
            }
        }

        public void Check(bool valid)
        {
            if (valid == false)
            {
                throw new Exception("Invalid value!");
            } 
        }
    }
}

