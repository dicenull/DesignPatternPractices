using System;
using System.Collections.Generic;
using System.Text;

namespace NumGeneratorObserver
{
	public class RandomNumberGenerator : NumberGenerator
	{
		private Random rnd = new Random();

		public override void Execute()
		{
			for(var i = 0;i < 20;i++)
			{
				Number = rnd.Next(50);
				NotifyObservers();
			}
		}
	}
}
