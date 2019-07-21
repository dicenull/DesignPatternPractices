using System;
using System.Collections.Generic;
using System.Text;

namespace TroubleChain
{
	public class NoSupport : Support
	{
		public NoSupport(string name)
			: base(name) { }

		protected override bool resolve(Trouble trouble)
		{
			return false;
		}
	}
}
