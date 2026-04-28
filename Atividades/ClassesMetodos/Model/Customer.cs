namespace Model
{
    public class Customer
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address? HomeAddress { get; set; }
        public Address ShippingAddress { get; set; } = null!;

        #endregion

        #region Constructor

        public Customer() { }

        public Customer(
            int id,
            string firstname,
            string lastname,
            string email,
            string phone,
            Address homeaddress,
            Address shippingaddress
        )
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            HomeAddress = homeaddress;
            ShippingAddress = shippingaddress;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName)) return false;
            if (string.IsNullOrWhiteSpace(LastName)) return false;
            if (string.IsNullOrWhiteSpace(Email)) return false;
            if (string.IsNullOrWhiteSpace(Phone)) return false;

            return true;
        }
        #endregion

    }
}