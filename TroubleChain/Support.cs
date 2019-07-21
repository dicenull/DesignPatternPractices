using System;
using System.Collections.Generic;
using System.Text;

namespace TroubleChain
{
	public abstract class Support
	{
		public string Name { get; }

		public Support Next { get; set; }

		public Support SetNext(Support next)
		{
			Next = next;

			return next;
		}

		public Support(string name)
		{
			Name = name;
		}

		public void DoSupport(Trouble trouble)
		{
			if (resolve(trouble))
			{
				done(trouble);
			}
			else if (Next != null)
			{
				Next.DoSupport(trouble);
			}
			else
			{
				fail(trouble);
			}

		}

		public override string ToString()
		{
			return $"[{Name}]";
		}

		protected abstract bool resolve(Trouble trouble);

		protected void done(Trouble trouble)
		{
			Console.WriteLine($"{trouble} is resolved by {this}.");
		}

		protected void fail(Trouble trouble)
		{
			Console.WriteLine($"{trouble} cannot be resolved.");
		}
	}
}
