﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPSender
{
	class Program
	{
		private const int port = 11001;
		static void Main(string[] args)
		{
			PlainUDPSender s = new PlainUDPSender(port);
			s.Start();
			Console.ReadKey();
		}
	}
}
