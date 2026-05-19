using kybe_domain.Common;

namespace kybe_domain.Models.ValueObject
{
    public class Address
    {
        public string City { get; private set; } = string.Empty;
        public string State { get; private set; } = string.Empty;
        public string Street { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public string ZipCode { get; private set; } = string.Empty;
        public string Neighborhood { get; private set; } = string.Empty;
        public string Complementary { get; private set; } = string.Empty;

        protected Address() { }
        public Address(string city, string state, string street, string number,
                        string zipCode, string neighborhood, string complementary)
        {
            City = Guard.AgainstNullOrWhiteSpace(city, nameof(City));
            State = Guard.AgainstNullOrWhiteSpace(state, nameof(State));
            Street = Guard.AgainstNullOrWhiteSpace(street, nameof(Street));
            Number = Guard.AgainstNullOrWhiteSpace(number, nameof(Number));
            ZipCode = Guard.AgainstNullOrWhiteSpace(zipCode, nameof(ZipCode));
            Neighborhood = Guard.AgainstNullOrWhiteSpace(neighborhood, nameof(Neighborhood));
            Complementary = Guard.AgainstNullOrWhiteSpace(complementary, nameof(Complementary));
        }


    }
}
