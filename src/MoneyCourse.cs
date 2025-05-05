using System.Globalization;
using System.Net;
using System.Xml;

namespace MoneyConverter
{
    public class MoneyCourse
    {
        WebClient client = new WebClient();
        string url = "https://www.cbr.ru/scripts/XML_daily.asp";

        public double GetRubleCourse()
        {
            NumberFormatInfo formatInfo = new NumberFormatInfo
            {
                NumberDecimalSeparator = ",",
            };

            string xml = client.DownloadString(url);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            XmlNode usdNode = xmlDoc.SelectSingleNode("//Valute[@ID='R01235']/Value");

            return double.Parse(usdNode.InnerText, formatInfo);
        }
    }
}
