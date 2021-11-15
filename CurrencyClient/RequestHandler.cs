using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CurrencyClient.CurrencyService;

namespace CurrencyClient
{
    public class RequestHandler
    {
        /**
        public static string HandleRequest(string message)
        {
            try
            {
                TcpClient client = new TcpClient(ConfigurationManager.AppSettings["host"], Int32.Parse(ConfigurationManager.AppSettings["port"]));
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                stream.Close();
                client.Close();
                return XmlConverter.ProcesarXmlConvertResponse(responseData);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
                return "";
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                return "";
            }
        }
        **/
    }
}
