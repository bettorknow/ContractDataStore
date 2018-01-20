using System;
using Properties.Contract.Address;
using Properties.Contract.Property;

namespace SouthParkDataStore
{
    public class Property : IProperty
    {
        public Property(IPostalAddress postalAddress)
        {
            PostalAddress = postalAddress;
        }

        public IPostalAddress PostalAddress { get; }
    }
}
