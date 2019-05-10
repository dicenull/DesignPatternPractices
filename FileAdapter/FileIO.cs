using System;
using System.Collections.Generic;
using System.Text;

namespace FileAdapter
{
	interface FileIO
	{
		void ReadFromFile(string fileName);
		void WriteToFile(string fileName);
		void SetValue(string key, string value);
		string GetValue(string key);
	}
}
