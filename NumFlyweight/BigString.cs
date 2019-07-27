using System;
using System.Collections.Generic;
using System.Text;

namespace NumFlyweight
{
	public class BigString
	{
		private BigChar[] bigChars;

		public BigString(string str, bool shared = true)
		{
			bigChars = new BigChar[str.Length];

			if(shared)
			{
				var factory = BigCharFactory.GetInstance();

				for (var i = 0; i < bigChars.Length; i++)
				{
					bigChars[i] = factory.GetBigChar(str[i]);
				}
			}
			else
			{
				for(var i  =0;i < bigChars.Length;i++)
				{
					bigChars[i] = new BigChar(str[i]);
				}
			}
		}

		public void Print()
		{
			for(var i = 0;i < bigChars.Length;i++)
			{
				bigChars[i].Print();
			}
		}
	}
}
