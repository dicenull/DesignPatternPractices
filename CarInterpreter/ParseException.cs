using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public class ParseException : Exception
	{
		public ParseException(string msg)
			: base(msg)
		{ }
	}
}
