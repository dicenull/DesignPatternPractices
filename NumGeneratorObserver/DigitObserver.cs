using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NumGeneratorObserver
{
	public class DigitObserver : IObserver
	{
		public void Update(NumberGenerator generator)
		{
			Console.WriteLine($"DigitObserver: {generator.Number}");

			Thread.Sleep(1000);
		}
	}
}
