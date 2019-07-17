using System;
using System.Text;

namespace StringDecorator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Shift_JISを登録
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			var b1 = new StringDisplay("Hello, world.");
			var b2 = new UpDownBorder(b1, '-');
			var b3 = new FullBorder(b2);

			b1.Show();
			b2.Show();
			b3.Show();


			var b4 =
				new FullBorder(
					new UpDownBorder(
						new SideBorder(
							new UpDownBorder(
								new SideBorder(
									new StringDisplay("こんにちは。"),
									'*'),
								'='),
							'|'),
						'/')
					);
			/*
			var b4 =
				new SideBorder(
					new FullBorder(
						new FullBorder(
							new SideBorder(
								new FullBorder(
									new StringDisplay("こんにちは。")
									),
								'*'
								)
							)
						),
					'/'
					);
			*/
			b4.Show();


			var md = new MultiStringDisplay();

			md.Add("おはようございます。");
			md.Add("こんにちは");
			md.Add("おやすみなさい、また明日。");
			md.Add("OK!");
			md.Show();

			var d1 = new SideBorder(md, '#');
			d1.Show();

			var d2 = new FullBorder(md);
			d2.Show();
		}
	}
}
