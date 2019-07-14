using System;
using System.Collections.Generic;
using System.Text;

namespace Displayer
{
	public class IncreaseDisplay : CountDisplay
	{
		private int step;

		public IncreaseDisplay(DisplayImpl impl, int step = 1) : base(impl)
		{
			this.step = step;
		}

		public void CountUpDisplay(int times)
		{
			int count = 0;

			for (int i = 0; i < times; i++)
			{
				MultiDisplay(count);

				count += step;
			}
		}
	}
}
