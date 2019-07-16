using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDirectory
{
	class FileTreatmentException : Exception
	{
		public FileTreatmentException()
		{ }

		public FileTreatmentException(string msg)
			: base(msg) { }
	}
}
