using System;
using System.Collections.Generic;
using System.Text;
using Properties.Contract.Address;
using Properties.Contract.Property;

namespace SouthParkDataStore.ExplicitAddress
{
    internal sealed class MarshResidence :  IProperty, IPostalAddress
    {
        public MarshResidence()
        {
            PostalAddress = this;
        }

        public IPostalAddress PostalAddress { get; }
        public string Address1 => "2001 E. Bonanza St.";
        public string Address2 => "South Park";
        public string Address3 => "Colorado";
        public string Postcode => "90210";
        public string Country => "USA";
    }
}
