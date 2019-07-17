using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	class FileTreatmentException : Exception
	{
		public FileTreatmentException()
		{ }

		public FileTreatmentException(string msg)
			: base(msg) { }
	}
}
