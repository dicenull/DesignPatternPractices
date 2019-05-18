using System;
using Framework;

namespace IdCard
{
	class IDCard : IProduct
	{
		public string Owner { get; }
		
		internal IDCard(string owner)
		{
			Console.WriteLine($"{owner}のカードを作ります");

			Owner = owner;
		}

		public void Use()
		{
			Console.WriteLine($"{Owner}のカードを使います");
		}
	}
}
