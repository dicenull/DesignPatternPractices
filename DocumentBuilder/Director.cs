using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder
{
	class Director
	{
		private Builder builder;

		public Director(Builder builder)
		{
			this.builder = builder;
		}

		public void Construct()
		{
			builder.MakeTitle("Greeting");
			builder.MakeString("朝から昼にかけて");
			builder.MakeItems(new[]
			{
				"おはようございます",
				"こんにちは"
			});

			builder.MakeString("夜に");
			builder.MakeItems(new[]
			{
				"こんばんは",
				"おやすみなさい",
				"おばんです"
			});

			builder.Close();
		}
	}
}
