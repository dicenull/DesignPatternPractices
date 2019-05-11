using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileAdapter
{
	class Properties
	{
		Dictionary<string, string> properties;

		public Properties()
		{
			properties = new Dictionary<string, string>();
		}

		public void Load(StreamReader reader)
		{
			while (!reader.EndOfStream)
			{
				var pair = reader.ReadLine()
					.Split(new[] { ' ', '=', ':', '\t' })
					.Where(str => str.Length != 0)
					.ToList();

				if (pair[0][0] == '#')
				{
					continue;
				}

				if (pair.Count != 2)
				{
					throw new IOException();
				}

				var key = pair[0];
				var value = pair[1];
				properties[key] = value;
			}
			
		}

		public void Store(StreamWriter writer, string header)
		{
			writer.WriteLine(header);

			foreach(var pair in properties)
			{
				writer.WriteLine($"{pair.Key}={pair.Value}");
			}

		}
	}
}
