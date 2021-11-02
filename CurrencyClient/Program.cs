using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string option, units, origen, destino = "";
                Boolean end = false;

                while (true)
                {
                    Console.WriteLine("Seleccione la moneda de origen");
                    Console.WriteLine("1. EUR");
                    Console.WriteLine("2. USD");
                    Console.WriteLine("3. SALIR");
                    option = Console.ReadLine();
                    origen = option == "1" ? "eur" : option == "2" ? "usd" : "";
                    if (option == "3")
                    {
                        end = true;
                        break;
                    }
                    else if (option == "1" || option == "2") {
                        Console.WriteLine("Seleccione la moneda de destino");
                        Console.WriteLine("1. EUR");
                        Console.WriteLine("2. USD");
                        Console.WriteLine("3. SALIR");
                        option = Console.ReadLine();
                        destino = option == "1" ? "eur" : option == "2" ? "usd" : "";
                        if (option == "3") end = true;
                        break;
                    }
                    else Console.WriteLine("Introduzca una opción válida!");
                }

                if (end) break;

                while (true)
                {
                    Console.WriteLine("Introduzca el valor a convertir");
                    units = Console.ReadLine();
                    try
                    {
                        Decimal.Parse(units);
                        break;
                    } catch(FormatException err)
                    {
                        Console.WriteLine("Introduzca un valor válido!");
                    }
                }

                Console.WriteLine(RequestHandler.HandleRequest(XmlConverter.GenerarPaqueteXmlConvertRequest(origen, destino, units)));
            }
        }
    }
}
