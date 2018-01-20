using System;
using System.Threading.Tasks;
using Library.Address.Contract;
using Properties.Contract.Address;

namespace Library.Address
{
    public class AddressGateway : IAddressGateway
    {
        public async Task<IPostalAddress> GetByPostalId(string postcode, string addressLine)
        {
            return await Task.FromResult(new PostalAddress("","","","",""));
        }
    }
}
