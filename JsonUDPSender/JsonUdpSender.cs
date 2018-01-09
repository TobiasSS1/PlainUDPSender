using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;
using Newtonsoft.Json;


namespace JsonUDPSender
{
	class JsonUdpSender
	{
		private readonly int PORT;

		public JsonUdpSender(int port)
		{
			PORT = port;
		}

		public void Start()
		{
			using (UdpClient client = new UdpClient())
			{
				IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);
				Car Car1 = new Car("Toyota", "Pink", "FA 423 123");

				var jsonserializedobject = JsonConvert.SerializeObject(Car1);


				//byte[] buffer = Encoding.ASCII.GetBytes(Car1.ToString());
				byte[] buffer = Encoding.ASCII.GetBytes(jsonserializedobject);


				client.Send(buffer, buffer.Length, ModtagerEP);

			}
		}
	}
}
