using System;
using System.Collections.Generic;
using System.Text;

namespace Displayer
{
	public abstract class DisplayImpl
	{
		public abstract void RawOpen();
		public abstract void RawPrint();
		public abstract void RawClose();
	}
}
