using System;
using System.Collections.Generic;
using System.Text;
using Properties.Contract.Address;
using Properties.Contract.Property;

namespace SouthParkDataStore.ExplicitAddress
{
    internal sealed class McCormickResidence : IProperty, IPostalAddress
    {
        public McCormickResidence()
        {
            PostalAddress = this;
        }

        public IPostalAddress PostalAddress { get; }
        public string Address1 => "635 Avenue de Los Mexicanos";
        public string Address2 => "South Park";
        public string Address3 => "Colorado";
        public string Postcode => "80440";
        public string Country => "USA";
    }
}
