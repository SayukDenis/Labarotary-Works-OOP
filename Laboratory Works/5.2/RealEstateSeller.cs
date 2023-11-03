using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class RealEstateSeller : BaseEntity
    {
        public string Apartment;
        public string AgencyID;

        public RealEstateSeller(IConnector connector = null, string id = null, string apartment = null) : base(connector, id)
        {
            this.Apartment = apartment;
        }

        public void Sell()
        {
            Console.WriteLine($"Seller {this.Identifier} is selling apartment {this.Apartment}...");
            _connector.SendRequest(this, RequestType.Selling);
        }
    }
}
