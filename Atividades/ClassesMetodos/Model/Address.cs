namespace Model
{
    public class Address
    {
        #region Properties
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string FederalState { get; set; } = string.Empty;
        #endregion

        #region Constructors
        public Address()
        {
        }

        public Address(
            int id,
            string street,
            string number,
            string city, 
            string postalCode, 
            string country, 
            string federalState
        )
        {
            Id = id;
            Street = street;
            Number = number;
            City = city;
            PostalCode = postalCode;
            Country = country;
            FederalState = federalState;
        }

        public bool Validate()
        { 
            if (string.IsNullOrWhiteSpace(Street)) return false;
            if (string.IsNullOrWhiteSpace(Number)) return false;
            if (string.IsNullOrWhiteSpace(City)) return false;
            if (string.IsNullOrWhiteSpace(PostalCode)) return false;
            if (string.IsNullOrWhiteSpace(Country)) return false;
            if (string.IsNullOrWhiteSpace(FederalState)) return false;

            return true;
        }
        
        #endregion
    }
}
