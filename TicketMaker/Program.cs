using System;
using System.Threading.Tasks;

namespace TicketMaker
{
	public class TicketMaker
	{
		private int ticket = 1000;

		public static TicketMaker Instance { get; } = new TicketMaker();

		private TicketMaker() { }

		public int NextTicketNumber
		{
			get
			{
				lock(Instance)
				{
					Console.WriteLine(ticket);
					return ticket++;
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var maker = TicketMaker.Instance;

			Parallel.For(0, 10, i =>
			{
				_ = maker.NextTicketNumber;
			});
		}
	}
}
