using System ;
using System.Collections.Generic ;
using NLog ;
using NUnit.Framework ;

namespace ConsoleApplication87{
	internal class Program{
		private static Logger logger = LogManager.GetCurrentClassLogger() ;

		public static void Main (string[] args)
		{
		}

		[Test]
		public void Test()
		{
			Assert.True (true);
		}
	}
}