using System;
using System.Collections.Generic;
using System.Text;

namespace Displayer
{
	public class RandomDisplay : CountDisplay
	{
		public RandomDisplay(DisplayImpl impl) : base(impl) { }

		public void RandDisplay(int times)
		{
			var rnd = new Random();

			MultiDisplay(rnd.Next(times));
		}
	}
}
