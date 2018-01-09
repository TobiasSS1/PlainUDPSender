using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlUDPSender
{
	public class XmlUDPSender
	{
		private readonly int PORT;

		public XmlUDPSender(int port)
		{
			PORT = port;	
		}

		public void Start()
		{
			using (UdpClient client = new UdpClient())
			{
				IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);
				Car Car1 = new Car("Toyota", "Pink", "FA 423 123");

				XmlSerializer xs = new XmlSerializer(typeof(Car));
				StringWriter sw = new StringWriter();
				xs.Serialize(sw, Car1);


				//byte[] buffer = Encoding.ASCII.GetBytes(Car1.ToString());
				byte[] buffer = Encoding.ASCII.GetBytes(sw.ToString());


				client.Send(buffer, buffer.Length, ModtagerEP);

			}
		}

	}
}
