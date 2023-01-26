using System;
namespace Calculator
{
	public interface ILogger
	{
		void Event(string message);
		void Error(string message);
	}
}

