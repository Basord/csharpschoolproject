using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static EndpointAddress ep;
        static _dllContract.iContract proxy;
        static string uri;
        static void Main(string[] args)
        {
            Client.Program.uri = "http://localhost:8010/SERVERWCF";
            Client.Program.ep = new EndpointAddress(Client.Program.uri);
            Client.Program.proxy = ChannelFactory<_dllContract.iContract>.CreateChannel(new BasicHttpBinding(), ep);

            string prenom;
            Console.WriteLine("Veuillez saisir votre prénom: \n?");
            prenom = Console.ReadLine();
            Console.WriteLine(proxy.hello_firstname(prenom));
            Console.Read();
        }
    }
}
