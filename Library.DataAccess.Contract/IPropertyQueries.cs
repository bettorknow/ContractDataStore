using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Properties.Contract.Property;

namespace Library.DataAccess.Contract
{
    public interface IPropertyQueries
    {
        Task<IProperty> GetSinglePropertyMatch(IProperty propertyCriteria);
        Task<IEnumerable<IProperty>> GetPropertyMatches(IProperty propertyCriteria);
        Task<IEnumerable<IProperty>> GetAllProperties(IProperty propertyCriteria, int maxResults = 100);
    }
}
