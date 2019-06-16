using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
	class Manager
	{
		private Dictionary<string, Product> showCase = new Dictionary<string, Product>();

		public void Register(string name, Product proto)
		{
			showCase[name] = proto;
		}

		public Product Create(string protoName)
		{
			var p = showCase[protoName];

			return p.CreateClone();
		}
	}
}
