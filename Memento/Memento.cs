using System;
using System.Collections.Generic;
using System.Text;

namespace GameMemento
{
	public class Memento
	{
		private List<string> fruits;

		public int Money { get; }

		public Memento(int money)
		{
			Money = money;
			fruits = new List<string>();
		}

		public void AddFruit(string fruit)
		{
			fruits.Add(fruit);
		}

		public IEnumerable<string> GetFruits()
		{
			return fruits;
		}
	}
}
