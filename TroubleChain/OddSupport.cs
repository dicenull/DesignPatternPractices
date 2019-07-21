using System;
using System.Collections.Generic;
using System.Text;

namespace TroubleChain
{
	public class OddSupport : Support
	{
		public OddSupport(string name)
			: base(name) { }

		protected override bool resolve(Trouble trouble)
		{
			if(trouble.Number % 2 == 1)
			{
				return true;
			}

			return false;
		}
	}
}
