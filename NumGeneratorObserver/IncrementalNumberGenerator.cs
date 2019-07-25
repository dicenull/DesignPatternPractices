using System;
using System.Collections.Generic;
using System.Text;

namespace NumGeneratorObserver
{
	public class IncrementalNumberGenerator : NumberGenerator
	{
		private int start, end, mount;

		public IncrementalNumberGenerator(int start, int end, int mount)
		{
			this.start = start;
			this.end = end;
			this.mount = mount;
		}

		public override void Execute()
		{
			for(Number = start; Number < end; Number += mount)
			{
				Console.WriteLine($"Increment Num: {Number}");
				NotifyObservers();
			}
		}
	}
}
