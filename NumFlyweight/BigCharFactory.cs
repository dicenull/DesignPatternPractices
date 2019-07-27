using System;
using System.Collections.Generic;
using System.Text;

namespace NumFlyweight
{
	public class BigCharFactory
	{
		private Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();

		private static BigCharFactory singleton = new BigCharFactory();

		private BigCharFactory() { }

		public static BigCharFactory GetInstance()
		{
			return singleton;
		}

		public BigChar GetBigChar(char charName)
		{
			var key = charName;

			BigChar bc;
			if (pool.ContainsKey(key))
			{
				bc = pool[key];
			}
			else
			{
				bc = new BigChar(charName);
				pool[key] = bc;
			}

			return bc;
		}
	}
}
