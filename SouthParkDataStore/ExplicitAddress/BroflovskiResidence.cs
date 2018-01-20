using System;
using System.Collections.Generic;
using System.Text;
using Properties.Contract.Address;
using Properties.Contract.Property;

namespace SouthParkDataStore.ExplicitAddress
{
    internal sealed class BroflovskiResidence : IProperty, IPostalAddress
    {
        public BroflovskiResidence()
        {
            PostalAddress = this;
        }

        public IPostalAddress PostalAddress { get; }
        public string Address1 => "1002 Avenue de los Mexicanos";
        public string Address2 => "South Park";
        public string Address3 => "Colorado";
        public string Postcode => "80440";
        public string Country => "USA";
    }
}
