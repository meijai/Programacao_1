namespace Model
{
    public class Customer : People
    {
        #region Properties
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        #endregion

        #region Constructor

        public Customer() { }

        public Customer(
            int id,
            string firstname,
            string lastname,
            string email,
            string phone
        )
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
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