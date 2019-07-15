using System;

namespace JankenStrategy
{
	public class WinningStrategy : IStrategy
	{
		private Random rnd;
		private bool won = false;
		private Hand prevHand;

		public WinningStrategy(int seed)
		{
			rnd = new Random(seed);
		}

		public Hand NextHand()
		{
			if(!won)
			{
				prevHand = Hand.GetHand((HandType)rnd.Next(3));
			}

			return prevHand;
		}

		public void Study(bool win)
		{
			won = win;
		}
	}
}
