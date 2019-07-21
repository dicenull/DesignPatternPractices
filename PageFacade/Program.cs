using System;

namespace PageFacade
{
	class Program
	{
		static void Main(string[] args)
		{
			PageMaker.MakeWelcomePage("dice@dice.com", "welcome.html");

			PageMaker.MakeLinkPage("linkpage.html");
		}
	}
}
