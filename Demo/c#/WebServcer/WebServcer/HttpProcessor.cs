using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServcer
{
    class HttpProcessor
    {
        public void parseRequest()
        {
            String request = inputStream.ReadLine();
            string[] tokens = request.Split(' ');
            if (tokens.Length != 3)
            {
                throw new Exception("invalid http request line");
            }
            http_method = tokens[0].ToUpper();
            http_url = tokens[1];
            http_protocol_versionstring = tokens[2];

            Console.WriteLine("starting: " + request);
        }
    }
}
