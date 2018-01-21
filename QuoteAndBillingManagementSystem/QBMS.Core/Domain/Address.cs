namespace QBMS.Core.Domain
{
    public class Address : EntityBase
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public AddressType AddressType { get; set; }
    }
}
