using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProxyNamedPrinter
{
	public class Printer : IPrintable
	{
		public string Name { get; set; }

		public Printer()
		{
			heavyJob("Creating Printer...");
		}

		public Printer(string name)
			: this()
		{
			Name = name;
		}

		public void Print(string str)
		{
			Console.WriteLine($"=== {Name} ===");
			Console.WriteLine(str);
		}

		private void heavyJob(string msg)
		{
			Console.Write(msg);

			for(var i = 0;i < 5;i++)
			{
				Thread.Sleep(1000);
				Console.Write(".");
			}

			Console.WriteLine("完了.");
		}
	}
}
