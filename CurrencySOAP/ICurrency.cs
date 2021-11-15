using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencySOAP
{
    [ServiceContract]
    public interface ICurrency
    {
        [OperationContract]
        CurrencyResponse ConvertCurrency(CurrencyRequest composite);
    }

    [DataContract]
    public class CurrencyRequest
    {
        [DataMember]
        public string originValue { get; set; }

        [DataMember]
        public string originCurrency { get; set; }

        [DataMember]
        public string destinationCurrency { get; set; }

    }

    [DataContract]
    public class CurrencyResponse
    {
        [DataMember]
        private string destinationValue { get; set; }

        [DataMember]
        private string destinationCurrency { get; set; }
    }
}
