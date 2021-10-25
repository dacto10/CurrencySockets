using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrancar();
        }
        public static void Arrancar()
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(ConfigurationManager.AppSettings["host"]);
                TcpListener server = new TcpListener(localAddr, Int32.Parse(ConfigurationManager.AppSettings["port"]));
                server.Start();
                Byte[] bytes = new Byte[256];
                String data = null;
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    data = null;
                    NetworkStream stream = client.GetStream();
                    Int32 i = stream.Read(bytes, 0, bytes.Length);
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i).Trim();
                    var tipoConversion = XmlConverter.ProcesarXmlConvertRequest(data, out decimal numeroAConvertir);
                    if (tipoConversion == "USD-EUR") data = XmlConverter.GenerarPaqueteXmlConvertResponse($"{Decimal.Multiply(numeroAConvertir, (decimal) 0.86)}", "eur");
                    else if (tipoConversion == "EUR-USD") data = XmlConverter.GenerarPaqueteXmlConvertResponse($"{Decimal.Multiply(numeroAConvertir, (decimal) 1.16)}", "usd");
                    else data = XmlConverter.GenerarPaqueteXmlConvertResponseError("ERROR: Divisa no reconocida " + tipoConversion);
                    Byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                    stream.Write(msg, 0, msg.Length);
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }
}
