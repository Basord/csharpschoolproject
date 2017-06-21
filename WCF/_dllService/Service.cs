using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _dllContract;

namespace _dllService
{
    public class Service : iContract
    {
        public string hello_firstname(string firstname)
        {
            return "Hello " + firstname + " ! ";
        }
    }
}
