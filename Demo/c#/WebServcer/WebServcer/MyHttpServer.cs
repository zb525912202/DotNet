using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServcer
{
    class MyHttpServer:HttpServer
    {
        public MyHttpServer(int port)
            : base(port)
        {
        }
        public override void handleGETRequest(HttpProcessor p)
        {
            throw new NotImplementedException();
        }

        public override void handlePOSTRequest(HttpProcessor p, System.IO.StreamReader inputData)
        {
            throw new NotImplementedException();
        }
    }
}
