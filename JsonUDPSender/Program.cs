using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonUDPSender
{
	class Program
	{
		private const int PORT = 11002;
		static void Main(string[] args)
		{
			JsonUdpSender s = new JsonUdpSender(PORT);
			s.Start();

			Console.WriteLine("End of receiver program...");
			Console.ReadLine();
		}
	}
}
