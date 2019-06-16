using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
	public abstract class Product : ICloneable
	{
		public abstract void Use(string s);
		public Product CreateClone()
		{
			return (Product)Clone();
		}

		public object Clone()
		{
			return this;
		}
	}
}
