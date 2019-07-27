using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyNamedPrinter
{
	public interface IPrintable
	{
		string Name { get; set; }

		void Print(string str);

	}
}
