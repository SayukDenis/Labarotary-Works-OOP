using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class RealEstateBuyer : BaseEntity
    {
        public string Apartment;

        public RealEstateBuyer(IConnector connector = null, string id = null, string apartment = null) : base(connector, id)
        {
            this.Apartment = apartment;
        }

        public void Buy()
        {
            Console.WriteLine($"Buyer {this.Identifier} is buying apartment {this.Apartment}...");
            _connector.SendRequest(this, RequestType.Buying);
        }
    }
}
