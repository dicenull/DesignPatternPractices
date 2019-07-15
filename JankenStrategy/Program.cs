using System;

namespace JankenStrategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("seed 1 :");
			int seed1 = int.Parse(Console.ReadLine());
			Console.Write("seed 2 :");
			int seed2 = int.Parse(Console.ReadLine());

			var player1 = new Player("Taro", new WinningStrategy(seed1));
			var player2 = new Player("Hana", new ProbStrategy(seed2));

			for(var i = 0;i < 10000;i++)
			{
				var nextHand1 = player1.NextHand();
				var nextHand2 = player2.NextHand();

				if(nextHand1.IsStrongerThan(nextHand2))
				{
					Console.WriteLine("Winner : " + player1);

					player1.Win();
					player2.Lose();
				}
				else if(nextHand2.IsStrongerThan(nextHand1))
				{
					Console.WriteLine("Winner : " + player2);

					player1.Lose();
					player2.Win();
				}
				else
				{
					Console.WriteLine("Even...");

					player1.Even();
					player2.Even();
				}
			}

			Console.WriteLine("Total result.");
			Console.WriteLine(player1.ToString());
			Console.WriteLine(player2.ToString());
		}
	}
}
