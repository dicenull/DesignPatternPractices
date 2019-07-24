using System;
using System.Collections.Generic;
using System.Text;

namespace NumGeneratorObserver
{
	public interface IObserver
	{
		void Update(NumberGenerator generator);
	}
}
