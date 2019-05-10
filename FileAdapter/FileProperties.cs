using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAdapter
{
	class FileProperties : FileIO
	{
		private Properties properties;

		public FileProperties()
		{
			properties = new Properties();
		}

		public string GetValue(string key)
		{
			throw new NotImplementedException();
		}

		public void ReadFromFile(string fileName)
		{
			properties.Load(new StreamReader(fileName));
		}

		public void SetValue(string key, string value)
		{
			var pair = $"{key}={value}";
			var stream = new MemoryStream(Encoding.UTF8.GetBytes(pair));

			using (var reader = new StreamReader(stream))
			{
				properties.Load(reader);
			}
		}

		public void WriteToFile(string fileName)
		{
			using (var writer = new StreamWriter(fileName))
			{
				properties.Store(writer, "# written by FileProperties");
			}
		}
	}
}
