using System;
using System.Threading;

namespace GameMemento
{
	class Program
	{
		static void Main(string[] args)
		{
			var gamer = new Gamer(100);
			var memento = gamer.createMemento();

			for(var i = 0;i < 100;i++)
			{
				Console.WriteLine("==== " + i);
				Console.WriteLine("現状: " + gamer);

				gamer.Bet();

				Console.WriteLine($"所持金は{gamer.Money}円になりました");

				if(gamer.Money > memento.Money)
				{
					Console.WriteLine("ほぞん");
					memento = gamer.createMemento();
				}
				else if(gamer.Money < memento.Money / 2)
				{
					Console.WriteLine("ふっき");
					gamer.RestoreMemento(memento);
				}

				Thread.Sleep(1000);
				Console.WriteLine();
			}
		}
	}
}
