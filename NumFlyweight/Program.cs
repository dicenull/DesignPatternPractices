using System;

namespace NumFlyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			var str = Console.ReadLine();
			var before = GC.GetTotalMemory(false);

			var bs = new BigString(str, false);
			var after = GC.GetTotalMemory(false);

			bs.Print();

			Console.WriteLine(after - before);
		}
	}
}
