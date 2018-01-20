using System;
using System.Threading.Tasks;
using Properties.Contract.Address;

namespace Library.Address.Contract
{
    public interface IAddressGateway
    {
        Task<IPostalAddress> GetByPostalId(string postcode, string addressLine);
    }
}
