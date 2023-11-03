using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class ConcreteConnector : IConnector
    {
        private List<RealEstateAgency> agencies = new List<RealEstateAgency>();
        private List<RealEstateSeller> sellers = new List<RealEstateSeller>();
        private List<RealEstateBuyer> buyers = new List<RealEstateBuyer>();

        public ConcreteConnector() { }

        public void AddAgency(RealEstateAgency agency)
        {
            agencies.Add(agency);
        }

        public void AddSeller(RealEstateSeller seller)
        {
            sellers.Add(seller);
        }

        public void AddBuyer(RealEstateBuyer buyer)
        {
            buyers.Add(buyer);
        }

        public void SendRequest(object sender, RequestType type)
        {
            switch (type)
            {
                case RequestType.Selling:
                    RealEstateSeller seller = (RealEstateSeller)sender;
                    foreach (var agencyItem in agencies)
                    {
                        if (agencyItem.Identifier == seller.AgencyID)
                        {
                            Console.WriteLine("Found!");
                            agencyItem.ApartmentsForSale.Add(seller.Apartment);
                            break;
                        }
                    }
                    break;

                case RequestType.Checking:
                    RealEstateAgency agency = (RealEstateAgency)sender;
                    bool isEnd = false;
                    foreach (var ag in agencies)
                    {
                        foreach (var apartment in ag.ApartmentsForSale)
                        {
                            if (apartment == agency.BufferApartment)
                            {
                                Console.WriteLine("Found!");
                                isEnd = true;
                                break;
                            }
                        }
                        if (isEnd)
                            break;
                    }
                    break;

                case RequestType.Buying:
                    RealEstateBuyer buyer = (RealEstateBuyer)sender;
                    bool isEnd2 = false;
                    foreach (var ag in agencies)
                    {
                        foreach (var apartment in ag.ApartmentsForSale)
                        {
                            if (apartment == buyer.Apartment)
                            {
                                Console.WriteLine("Found!");
                                isEnd2 = true;
                                break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
