using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyNamedPrinter
{
	public class PrinterProxy<T> : IPrintable where T : IPrintable, new()
	{
		private T real;

		private string name;

		public string Name
		{
			get => name;

			set
			{
				if (real != null)
				{
					lock (real)
					{
						real.Name = value;
					}
				}
				
				this.name = value;
			}
		}


		public PrinterProxy()
		{

		}

		public PrinterProxy(string name)
		{
			Name = name;
		}

		public void Print(string str)
		{
			realize();

			real.Print(str);
		}

		private void realize()
		{
			lock (this)
			{
				if (real == null)
				{
					real = new T();
					real.Name = name;
				}
			}
		}

	}
}
