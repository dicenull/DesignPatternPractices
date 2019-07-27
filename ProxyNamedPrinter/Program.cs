using System;

namespace ProxyNamedPrinter
{
	class Program
	{
		static void Main(string[] args)
		{
			IPrintable p = new PrinterProxy<Printer>("Alice");

			Console.WriteLine("Name: " + p.Name);

			p.Name = "Bob";

			Console.WriteLine("Name: " + p.Name);

			p.Print("Hello, world.");
		}
	}
}
