using System;

namespace NumGeneratorObserver
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberGenerator generator = new RandomNumberGenerator();
			IObserver obs1 = new DigitObserver();
			IObserver obs2 = new GraphObserver();

			generator.AddObserver(obs1);
			generator.AddObserver(obs2);

			generator.Execute();
		}
	}
}
