using  _5._2;
using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteConnector();

            var agency1 = new RealEstateAgency(mediator, "A1");
            var agency2 = new RealEstateAgency(mediator, "A2");
            var seller1 = new RealEstateSeller(mediator, "S1", "Apartment1") { AgencyID = "A1" };
            var seller2 = new RealEstateSeller(mediator, "S2", "Apartment2") { AgencyID = "A2" };
            var buyer1 = new RealEstateBuyer(mediator, "B1", "Apartment1");
            var buyer2 = new RealEstateBuyer(mediator, "B2", "Apartment3");

            mediator.AddAgency(agency1);
            mediator.AddAgency(agency2);
            mediator.AddSeller(seller1);
            mediator.AddSeller(seller2);
            mediator.AddBuyer(buyer1);
            mediator.AddBuyer(buyer2);

            buyer1.Buy();
            buyer2.Buy();
            seller1.Sell();
            seller2.Sell();
            agency1.Check("Apartment1");
            agency2.Check("Apartment2");
        }
    }
}
