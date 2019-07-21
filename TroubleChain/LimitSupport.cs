using System;
using System.Collections.Generic;
using System.Text;

namespace TroubleChain
{
	public class LimitSupport : Support
	{
		private int limit;

		public LimitSupport(string name, int limit)
			:base(name)
		{
			this.limit = limit;
		}

		protected override bool resolve(Trouble trouble)
		{
			if(trouble.Number < limit)
			{
				return true;
			}

			return false;
		}
	}
}
