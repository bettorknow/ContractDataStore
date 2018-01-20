using Properties.Contract.Address;

namespace Properties.Contract.Property
{
    public interface IProperty
    {
        IPostalAddress PostalAddress { get; }
    }
}
