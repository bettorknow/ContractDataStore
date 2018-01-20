using System;
using System.Collections.Generic;
using System.Text;

namespace Properties.Contract.Address
{
    public interface IPostalAddress
    {
        string Address1 { get; }
        string Address2 { get; }
        string Address3 { get; }
        string Postcode { get; }
        string Country { get; }
    }
}
