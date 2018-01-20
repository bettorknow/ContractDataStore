using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Contract;
using Properties.Contract.Property;

namespace SouthParkDataStore.Queries
{
    public sealed class QueryRunner : IPropertyQueries
    {
        public async Task<IProperty> GetSinglePropertyMatch(IProperty propertyCriteria)
        {
            var store = new DataStore();
            return await Task.FromResult(store.Where(x => x.PostalAddress.Address1 == propertyCriteria.PostalAddress.Address1
                             && x.PostalAddress.Address2 == propertyCriteria.PostalAddress.Address2
                             && x.PostalAddress.Address3 == propertyCriteria.PostalAddress.Address1
                             && x.PostalAddress.Country == propertyCriteria.PostalAddress.Country
                             && x.PostalAddress.Postcode == propertyCriteria.PostalAddress.Postcode).Single());
        }

        public async Task<IEnumerable<IProperty>> GetPropertyMatches(IProperty propertyCriteria)
        {
            var store = new DataStore();
            return await Task.FromResult(store.Where(x => x.PostalAddress.Address1 == propertyCriteria.PostalAddress.Address1
                                    || x.PostalAddress.Address2 == propertyCriteria.PostalAddress.Address2
                                    || x.PostalAddress.Address3 == propertyCriteria.PostalAddress.Address1
                                    || x.PostalAddress.Country == propertyCriteria.PostalAddress.Country
                                    || x.PostalAddress.Postcode == propertyCriteria.PostalAddress.Postcode));
        }

        public async Task<IEnumerable<IProperty>> GetAllProperties(IProperty propertyCriteria, int maxResults = 100)
        {
            return await Task.FromResult(new DataStore().ToList());
        }
    }
}
