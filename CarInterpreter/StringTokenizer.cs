using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInterpreter
{
	public class StringTokenizer
	{
		private List<string> tokens;
		private int index;
		private char[] sep = { ' ', ',', '.', ':', '\t' };

		public StringTokenizer(string text)
		{
			tokens = text.Split(sep).ToList();
			index = 0;
		}

		public bool HasNextToken
		{
			get => (index < tokens.Count);
		}

		public string NextToken()
		{
			int currentIndex = index;
			index++;

			return tokens[currentIndex];
		}
	}
}
