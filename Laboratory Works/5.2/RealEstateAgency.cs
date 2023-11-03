namespace _5._2
{
    internal class RealEstateAgency : BaseEntity
    {
        public List<string> ApartmentsForSale = new List<string>();
        public List<string> ApartmentsToBuy = new List<string>();
        public string BufferApartment;

        public RealEstateAgency(IConnector connector = null, string id = null) : base(connector, id)
        {
        }

        public void Check(string searchingApartment)
        {
            BufferApartment = searchingApartment;
            _connector.SendRequest(this, RequestType.Checking);
        }
    }
}
