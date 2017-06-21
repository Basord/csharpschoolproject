using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        private static string uri;
        private static ServiceHost server;
        static void Main(string[] args)
        {
            ini_serv();
            Console.WriteLine("OK");
            Console.Read();
        }

        static bool ini_serv()
        {
            Server.Program.uri = "http://localhost:8010/SERVERWCF";
            Server.Program.server = new ServiceHost(typeof(_dllService.Service));

            Server.Program.server.AddServiceEndpoint(typeof(_dllContract.iContract), new BasicHttpBinding(), Server.Program.uri);
            Server.Program.server.Open();

            return true;
        }
    }
}
