namespace DisplayTemplate
{
	abstract class DisplayBase
	{
		protected abstract void Open();

		protected abstract void Print();
		protected abstract void Close();

		public void Display()
		{
			Open();

			for(var i = 0;i < 5;i++)
			{
				Print();
			}

			Close();
		}
	}
}
