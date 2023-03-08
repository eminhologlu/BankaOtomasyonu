using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinMarketCap;

namespace Banka_Otomasyonu
{
    class KriptoCek
    {
        public static string getWebResponse(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            Stream responseStream = webResponse.GetResponseStream();
            StreamReader _responseStream = new StreamReader(responseStream);
            return _responseStream.ReadToEnd();
        }
        public decimal getBitcoinInUSD()
        {
            string btc = getWebResponse("https://www.bitstamp.net/api/ticker/");
            int pos1 = btc.IndexOf("last", 0);
            int pos2 = btc.IndexOf(":", pos1);
            int pos3 = btc.IndexOf(",", pos2);
            return Convert.ToDecimal(btc.Substring(pos2 + 3, pos3 - pos2 - 4));
        }
        public decimal getEthInUSD()
        {
            string eth = getWebResponse("https://www.bitstamp.net/api/v2/ticker/ethusd");
            int pos1 = eth.IndexOf("last", 0);
            int pos2 = eth.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(eth.Substring(pos2 + 3, 6));
            return tam/10;
        }
        public decimal getLtcInUSD()
        {
            string ltc = getWebResponse("https://www.bitstamp.net/api/v2/ticker/ltcusd");
            int pos1 = ltc.IndexOf("last", 0);
            int pos2 = ltc.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(ltc.Substring(pos2 + 3, 5));
            return tam/100;
        }
        public decimal getXrpInUSD()
        {
            string xrp = getWebResponse("https://www.bitstamp.net/api/v2/ticker/xrpusd");
            int pos1 = xrp.IndexOf("last", 0);
            int pos2 = xrp.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(xrp.Substring(pos2 + 5, 2));
            return tam/100;
        }
        public decimal getMaticInUSD()
        {
            string matic = getWebResponse("https://www.bitstamp.net/api/v2/ticker/maticusd");
            int pos1 = matic.IndexOf("last", 0);
            int pos2 = matic.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(matic.Substring(pos2 + 5, 3));
            return tam / 1000;
        }
        public decimal getAdaInUSD()
        {
            string ada = getWebResponse("https://www.bitstamp.net/api/v2/ticker/adausd");
            int pos1 = ada.IndexOf("last", 0);
            int pos2 = ada.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(ada.Substring(pos2 + 5, 3));
            return tam / 1000;
        }
        public decimal getLinkInUSD()
        {
            string link = getWebResponse("https://www.bitstamp.net/api/v2/ticker/linkusd");
            int pos1 = link.IndexOf("last", 0);
            int pos2 = link.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(link.Substring(pos2 + 3, 4));
            return tam / 100;
        }
        public decimal getChzInUSD()
        {
            string chz = getWebResponse("https://www.bitstamp.net/api/v2/ticker/chzusd");
            int pos1 = chz.IndexOf("last", 0);
            int pos2 = chz.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(chz.Substring(pos2 + 5, 4));
            return tam / 10000;
        }
        public decimal getAvaxInUSD()
        {
            string avax = getWebResponse("https://www.bitstamp.net/api/v2/ticker/avaxusd");
            int pos1 = avax.IndexOf("last", 0);
            int pos2 = avax.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(avax.Substring(pos2 + 3, 4));
            return tam / 10;
        }
        public decimal getSolInUSD()
        {
            string sol = getWebResponse("https://www.bitstamp.net/api/v2/ticker/solusd");
            int pos1 = sol.IndexOf("last", 0);
            int pos2 = sol.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(sol.Substring(pos2 + 3, 4));
            return tam / 10;
        }
        public decimal getDotInUSD()
        {
            string dot = getWebResponse("https://www.bitstamp.net/api/v2/ticker/dotusd");
            int pos1 = dot.IndexOf("last", 0);
            int pos2 = dot.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(dot.Substring(pos2 + 3, 4));
            return tam / 100;
        }
        public decimal getNearInUSD()
        {
            string near = getWebResponse("https://www.bitstamp.net/api/v2/ticker/nearusd");
            int pos1 = near.IndexOf("last", 0);
            int pos2 = near.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(near.Substring(pos2 + 3, 4));
            return tam / 100;
        }
        public decimal getEnjInUSD()
        {
            string enj = getWebResponse("https://www.bitstamp.net/api/v2/ticker/enjusd");
            int pos1 = enj.IndexOf("last", 0);
            int pos2 = enj.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(enj.Substring(pos2 + 3, 5));
            return tam / 1000;
        }
        public decimal getAlgoInUSD()
        {
            string algo = getWebResponse("https://www.bitstamp.net/api/v2/ticker/algousd");
            int pos1 = algo.IndexOf("last", 0);
            int pos2 = algo.IndexOf(":", pos1);
            decimal tam = Convert.ToDecimal(algo.Substring(pos2 + 3, 5));
            return tam / 1000;
        }
    }
}
