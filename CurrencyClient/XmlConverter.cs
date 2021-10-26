using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyClient
{
    public class XmlConverter
    {
        public static string ProcesarXmlConvertResponse(string xmlData)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            var message = doc.SelectSingleNode("//ConvertResponse");
            var nodeUnits = doc.SelectSingleNode("//units");
            var toUnits = doc.SelectSingleNode("//to");
            return nodeUnits != null ? $"{nodeUnits.InnerText} {toUnits.InnerText.ToUpper().Trim()}" : message.InnerText;
        }
        public static string GenerarPaqueteXmlConvertRequest(string fromCurrency, string finalCurrency, string units)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode responseNode = doc.CreateElement("ConvertResponse");
            doc.AppendChild(responseNode);
            XmlNode unitsNode = doc.CreateElement("units");
            unitsNode.InnerText = units;
            responseNode.AppendChild(unitsNode);
            XmlNode toNode = doc.CreateElement("to");
            toNode.InnerText = finalCurrency;
            responseNode.AppendChild(toNode);
            XmlNode fromNode = doc.CreateElement("from");
            fromNode.InnerText = fromCurrency;
            responseNode.AppendChild(fromNode);
            return doc.InnerXml;
        }
    }

}
