using System;
using System.Collections.Generic;
using Properties.Contract.Property;

namespace Library.DataAccess.Contract
{
    public interface IPropertyQueries
    {
        IProperty GetSinglePropertyMatch(IProperty propertyCriteria);
        IEnumerable<IProperty> GetPropertyMatches(IProperty propertyCriteria);
        IEnumerable<IProperty> GetAllProperties(IProperty propertyCriteria, int maxResults = 100);
    }
}
