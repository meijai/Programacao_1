namespace Model
{
    public class Address
    {
        public int Id { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string FederalState { get; set; } = string.Empty;
        public AddressType AddressType { get; set; }
    }

    public enum AddressType
    {
        Residential,
        Rural,
        Commercial
    }
}
