using System;

namespace Displayer
{
	class Program
	{
		static void Main(string[] args)
		{
			var d1 = new Display(new TextDisplayImpl("text.txt"));
			var d2 = new RandomDisplay(new StringDisplayImpl("Hello, World."));
			CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

			var d4 = new IncreaseDisplay(new CharDisplayImpl('<', '*', '>'));
			var d5 = new IncreaseDisplay(new CharDisplayImpl('|', '#', '-'), 2);

			d1.ToDisplay();
			d2.RandDisplay(3);
			d2.RandDisplay(3);
			d2.RandDisplay(3);
			d2.RandDisplay(3);

			d4.CountUpDisplay(5);
			d5.CountUpDisplay(6);
		}
	}
}
