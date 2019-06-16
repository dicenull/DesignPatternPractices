using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder
{
	public abstract class Builder
	{
		private bool initialized = false;

		public void MakeTitle(string title)
		{
			if(initialized)
			{
				return;
			}

			initialized = true;
			buildTitle(title);
		}
		public void MakeString(string str)
		{
			if(!initialized)
			{
				return;
			}

			buildTitle(str);
		}
		public void MakeItems(IEnumerable<string> items)
		{
			if(!initialized)
			{
				return;
			}

			buildItems(items);
		}
		public void Close()
		{
			if(!initialized)
			{
				return;
			}

			done();
		}

		protected abstract void buildTitle(string title);
		protected abstract void buildString(string str);
		protected abstract void buildItems(IEnumerable<string> items);
		protected abstract void done();
	}
}
