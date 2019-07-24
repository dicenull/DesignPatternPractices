using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NumGeneratorObserver
{
	public class GraphObserver : IObserver
	{
		public void Update(NumberGenerator generator)
		{
			Console.WriteLine("GraphObserver: ");

			int count = generator.Number;
			for(var i = 0;i < count;i++)
			{
				Console.Write("*");
			}
			Console.WriteLine();

			Thread.Sleep(1000);
		}
	}
}
