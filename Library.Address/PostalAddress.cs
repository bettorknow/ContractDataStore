using Properties.Contract.Address;

namespace Library.Address
{
    public sealed class PostalAddress : IPostalAddress
    {
        public PostalAddress(string address1, string address2, string address3, string postcode, string country)
        {
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
            Postcode = postcode;
            Country = country;
        }

        public string Address1 { get; }
        public string Address2 { get; }
        public string Address3 { get; }
        public string Postcode { get; }
        public string Country { get; }
    }
}
