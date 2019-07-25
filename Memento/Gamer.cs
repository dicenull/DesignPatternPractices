using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameMemento
{
	public class Gamer
	{
		private List<string> fruits = new List<string>();
		private Random rnd = new Random();
		private static string[] fruitsName =
		{
			"リンゴ", "ぶどう", "バナナ", "みかん"
		};

		public int Money { get; private set; }

		public Gamer(int money)
		{
			Money = money;
		}

		public void Bet()
		{
			int dice = rnd.Next(6) + 1;

			switch (dice)
			{
				case 1:
					Money += 100;
					Console.WriteLine("所持金が増えました");
					break;

				case 2:
					Money /= 2;
					Console.WriteLine("所持金が半分になりました");
					break;

				case 6:
					string f = getFruit();
					Console.WriteLine($"フルーツ({f})をもらいました");
					fruits.Add(f);
					break;

				default:
					Console.WriteLine("何も起こりませんでした。");
					break;
			}


		}

		public Memento createMemento()
		{
			var m = new Memento(Money);

			foreach(var f in fruits)
			{
				m.AddFruit(f);
			}

			return m;
		}

		public void RestoreMemento(Memento memento)
		{
			Money = memento.Money;
			fruits = memento.GetFruits().ToList();
		}

		public override string ToString()
		{
			return $"[money = {Money}, fruits = {string.Join(',', fruits)}";
		}

		private string getFruit()
		{
			var prefix = "";

			if(rnd.Next(2) == 1)
			{
				prefix = "おいしい";
			}

			return prefix + fruitsName[rnd.Next(fruitsName.Length)];
		}
	}
}
