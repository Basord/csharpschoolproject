using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace _dllContract
{
    [ServiceContract(Namespace ="http://RilaWCF.fr")]
    public interface iContract
    {
        [OperationContract]
        string hello_firstname(string firstname);
    }
}
