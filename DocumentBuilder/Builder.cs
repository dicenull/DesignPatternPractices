using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder
{
	interface Builder
	{
		void MakeTitle(string title);
		void MakeString(string str);
		void MakeItems(IEnumerable<string> items);
		void Close();
	}
}
