using System;
using Framework;
using IdCard;

namespace CardFactory
{
	class Program
	{
		static void Main()
		{
			Factory factory = new IDCardFactory();

			IProduct card1 = factory.Create("与謝野晶子");
			IProduct card2 = factory.Create("dice");
			IProduct card3 = factory.Create("owner");

			card1.Use();
			card2.Use();
			card3.Use();
		}
	}
}
