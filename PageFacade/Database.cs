using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PageFacade
{
	public class Database
	{
		private Database() { }

		public static Properties GetProperties(string dbName)
		{
			var fileName = dbName + ".txt";
			var prop = new Properties();

			prop.Load(new StreamReader(fileName));

			return prop;
		}
	}
}
