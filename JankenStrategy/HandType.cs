using System;
using System.Collections.Generic;
using System.Text;

namespace JankenStrategy
{
	public enum HandType
	{
		G, C, P
	}

	public enum Result
	{
		Win, Lose, Draw
	}

	public static class HandTypeExtend
	{
		public static string ToString(this HandType type)
		{
			switch (type)
			{
				case HandType.G:
					return "グー";
				case HandType.C:
					return "チョキ";
				case HandType.P:
					return "パー";
				default:
					return "";
			}
		}

		public static HandType Next(this HandType type)
		{
			return (HandType)(((int)type + 1) % 3);
		}
	}

}
