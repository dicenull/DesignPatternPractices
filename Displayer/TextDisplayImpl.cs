using System.IO;

namespace Displayer
{
	public class TextDisplayImpl : DisplayImpl
	{
		StreamReader reader;
		string path;

		public TextDisplayImpl(string path)
		{
			this.path = path;
		}

		public override void RawOpen()
		{
			reader = new StreamReader(path);
		}

		public override void RawPrint()
		{
			System.Console.WriteLine(reader.ReadToEnd());
		}

		public override void RawClose()
		{
			reader.Close();
		}

	}
}
