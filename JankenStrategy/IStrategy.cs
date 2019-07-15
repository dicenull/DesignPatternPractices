using System;
using System.Collections.Generic;
using System.Text;

namespace JankenStrategy
{
	public interface IStrategy
	{
		Hand NextHand();
		void Study(bool win);
	}
}
