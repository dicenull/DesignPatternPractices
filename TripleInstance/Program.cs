using System;

namespace TripleInstance
{
	public class Triple
	{
		private static Triple[] instance = new[]
		{
			new Triple(0),
			new Triple(1),
			new Triple(2)
		};

		private readonly int id;

		private Triple(int id)
		{
			this.id = id;
		}

		public static Triple GetInstance(int id)
		{
			return instance[id];
		}

		public override string ToString()
		{
			return $"id = {id}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			for(var i = 0;i < 3;i++)
			{
				Console.WriteLine(Triple.GetInstance(i).ToString());
			}
		}
	}
}
