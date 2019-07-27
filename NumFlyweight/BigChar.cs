using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NumFlyweight
{
	public class BigChar
	{
		private string fontData;

		public BigChar(char charName)
		{
			var reader = new StreamReader("big" + charName + ".txt");

			string line;
			var builder = new StringBuilder();

			while((line = reader.ReadLine()) != null)
			{
				builder.AppendLine(line);
			}

			reader.Close();
			fontData = builder.ToString();
		}

		public void Print()
		{
			Console.Write(fontData);
		}
	}
}
