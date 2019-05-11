using System;

namespace DisplayTemplate
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayBase d1 = new CharDisplay('Y');
			DisplayBase d2 = new StringDisplay("Yosano");
			DisplayBase d3 = new StringDisplay("晶子");

			d1.Display();
			d2.Display();
			d3.Display();
		}
	}
}
