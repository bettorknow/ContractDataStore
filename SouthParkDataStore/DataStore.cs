using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties.Contract.Property;
using SouthParkDataStore.ExplicitAddress;

namespace SouthParkDataStore
{
    public class DataStore
    {
        private readonly List<IProperty> _properties = new List<IProperty>();

        public DataStore()
        {
            AddPropertiesToStore();
        }

        private void AddPropertiesToStore()
        {
            _properties.Add(new Property(new CartmanResidence()));
        }

        public List<IProperty> Where(Func<IProperty, bool> predicate)
        {
            return _properties.Where(predicate).ToList();
        }

        public List<IProperty> ToList()
        {
            return _properties;
        }
    }
}
