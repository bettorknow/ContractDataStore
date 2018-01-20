using System;
using Properties.Contract.Address;
using Properties.Contract.Property;

namespace SouthParkDataStore
{
    internal class Property : IProperty
    {
        public Property(IPostalAddress postalAddress)
        {
            PostalAddress = postalAddress;
        }

        public IPostalAddress PostalAddress { get; }
    }
}
