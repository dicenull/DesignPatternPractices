using System;
using Framework;

namespace IdCard
{
	class IDCard : IProduct
	{
		private static int count = 0;

		public int Id { get; }

		public string Owner { get; }
		
		internal IDCard(string owner)
		{
			Console.WriteLine($"{owner}のカードを作ります");

			Owner = owner;
			Id = count;

			count++;
		}

		public void Use()
		{
			Console.WriteLine($"{Owner}( {Id} )のカードを使います");
		}
	}
}
