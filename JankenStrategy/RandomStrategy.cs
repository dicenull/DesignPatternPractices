using System;
using System.Collections.Generic;
using System.Text;

namespace JankenStrategy
{
	class RandomStrategy : IStrategy
	{
		private Random rnd;

		public RandomStrategy(int seed)
		{
			rnd = new Random(seed);
		}

		public Hand NextHand()
		{
			return Hand.GetHand((HandType)rnd.Next(3));
		}

		public void Study(bool win)
		{
			// none
		}
	}
}
