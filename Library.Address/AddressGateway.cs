using System;
using System.Threading.Tasks;
using Library.Address.Contract;
using Library.DataAccess.Contract;
using Properties.Contract.Address;

namespace Library.Address
{
    public class AddressGateway : IAddressGateway
    {
        private IPropertyQueries _properties;

        public AddressGateway(IPropertyQueries properties)
        {
            _properties = properties;
        }

        public async Task<IPostalAddress> GetByPostalId(string postcode, string addressLine)
        {
            return await _properties.GetPropertyMatches(new Property(new PostalAddress(addressLine, "", "", postcode, "")));
        }
    }
}
