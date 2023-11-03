using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal interface IConnector
    {
        void SendRequest(object sender, RequestType type);
    }
}
