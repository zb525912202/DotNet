using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    class Program
    {
        static void Main(string[] args)
        {

            long s =   ip2long( GetIP());
            Action<long> cw = Console.WriteLine;
            
            cw(s);
            Console.ReadKey();
            
            
        }



        public static long ip2long(String ip)
        {
            System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(ip);
            byte[] bytes = ipaddress.GetAddressBytes();
            Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }
        static string GetIP()
        {
            string strUrl = "http://www.baidu.com"; //获得IP的网址了
            Uri uri = new Uri(strUrl);
            WebRequest wr = WebRequest.Create(uri);
            Stream s = wr.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(s, Encoding.Default);
            string all = sr.ReadToEnd(); //读取网站的数据
            int i = all.IndexOf("[") + 1;
            string tempip = all.Substring(i, 15);
            string ip = tempip.Replace("]", "").Replace(" ", "");
            return ip;
        }
    }
}
