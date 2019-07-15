using System;

namespace JankenStrategy
{
	public class ProbStrategy : IStrategy
	{
		private Random rnd;
		private HandType prevHand = HandType.G;
		private HandType currentHand = HandType.G;
		private int[,] history =
			{
				{1,1,1 },
				{1,1,1 },
				{1,1,1 }
			};

		public ProbStrategy(int seed)
		{
			rnd = new Random(seed);
		}

		public Hand NextHand()
		{
			int bet = rnd.Next(getSum((int)currentHand));
			HandType hand = HandType.G;

			if(bet < history[(int)currentHand, 0])
			{
				hand = HandType.G;
			}
			else if(bet < history[(int)currentHand, 0] + history[(int)currentHand, 1])
			{
				hand = HandType.C;
			}
			else
			{
				hand = HandType.P;
			}

			prevHand = currentHand;
			currentHand = hand;

			return Hand.GetHand(hand);
		}

		private int getSum(int hv)
		{
			int sum = 0;
			for(int i = 0;i < 3;i++)
			{
				sum += history[hv, i];
			}

			return sum;
		}

		public void Study(bool win)
		{
			if(win)
			{
				history[(int)prevHand, (int)currentHand]++;
			}
			else
			{
				history[(int)prevHand, (int)currentHand.Next()]++;
				history[(int)prevHand, (int)currentHand.Next().Next()]++;
			}
		}
	}
}
