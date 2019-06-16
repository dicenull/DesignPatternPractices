using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
	interface Product : ICloneable
	{
		void Use(string s);

		Product CreateClone();
	}
}
