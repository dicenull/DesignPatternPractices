using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public class Context
	{
		private StringTokenizer tokenizer;
		public string CurrentToken { get; private set; }

		public Context(string text)
		{
			tokenizer = new StringTokenizer(text);

			NextToken();
		}

		public string NextToken()
		{
			if(tokenizer.HasNextToken)
			{
				CurrentToken = tokenizer.NextToken();
			}
			else
			{
				CurrentToken = null;
			}

			return CurrentToken;
		}


		public void SkipToken(string token)
		{
			if(!(token == CurrentToken))
			{
				throw new ParseException($"Warning: {token} is expected, but {CurrentToken} is found.");
			}

			NextToken();
		}

		public int CurrentNumber
		{
			get
			{
				return int.Parse(CurrentToken);
			}
		}
	}
}
