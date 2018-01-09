using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUDPSender
{
	class Program
	{
		private const int port = 11002;
		static void Main(string[] args)
		{
			XmlUDPSender s = new XmlUDPSender(port);
			s.Start();

			Console.WriteLine("End of sender program...");
			Console.ReadKey();
		}
	}
}
