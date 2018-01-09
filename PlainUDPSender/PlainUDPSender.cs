using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainUDPSender
{
	public class PlainUDPSender
	{
		private readonly int PORT;

		public PlainUDPSender(int port)
		{
			PORT = port;	
		}

		public void Start()
		{
			using (UdpClient client = new UdpClient())
			{
				IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);

				Car Car1 = new Car("Toyota", "Pink", "FA 423 123");
				byte[] buffer = Encoding.ASCII.GetBytes(Car1.ToString());

				client.Send(buffer, buffer.Length, ModtagerEP);
			}
		}
	}
}
