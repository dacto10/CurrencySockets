using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencySOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Currency" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Currency.svc o Currency.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Currency : ICurrency
    {
        public CurrencyResponse ConvertCurrency(CurrencyRequest request)
        {
            if (request.originCurrency == "EUR" && request.destinationCurrency == "USD") return new CurrencyResponse($"{Decimal.Parse(request.originValue) * (decimal) 1.14}", request.destinationCurrency);
            else if (request.originCurrency == "USD" && request.destinationCurrency == "EUR") return new CurrencyResponse($"{Decimal.Parse(request.originValue) * (decimal) 0.88}", request.destinationCurrency);
            else return null;
        }
    }
}
