using System;
using System.Collections.Generic;
using System.Text;

namespace JankenStrategy
{
	public class Hand
	{
		public static readonly Hand[] hands =
		{
			new Hand(HandType.G),
			new Hand(HandType.C),
			new Hand(HandType.P)
		};

		private HandType type;

		public Hand(HandType type)
		{
			this.type = type;
		}

		public static Hand GetHand(HandType type)
		{
			return hands[(int)type];
		}

		public bool IsStrongerThan(Hand h)
		{
			return fight(h) == Result.Win;
		}

		public bool IsWeakerThan(Hand h)
		{
			return fight(h) == Result.Lose;
		}


		private Result fight(Hand h)
		{
			if(this == h)
			{
				return Result.Draw;
			}
			else if(type.Next() == h.type)
			{
				return Result.Win;
			}
			else
			{
				return Result.Lose;
			}
		}

		public override string ToString()
		{
			return type.ToString();
		}
	}
}
