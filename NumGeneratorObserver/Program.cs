using System;

namespace NumGeneratorObserver
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberGenerator generator = new IncrementalNumberGenerator(1, 100, 3);
			IObserver obs1 = new DigitObserver();
			IObserver obs2 = new GraphObserver();

			generator.AddObserver(obs1);
			generator.AddObserver(obs2);

			generator.Execute();
		}
	}
}
