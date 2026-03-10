namespace Exemplo_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? EmailAdress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Validate()
        {
            if (string.IsNullOrEmpty(EmailAdress))
                return false;
            if (string.IsNullOrEmpty(FirstName))
                return false;
            if (string.IsNullOrEmpty(LastName))
                return false;
            return true;
        }
    }
}
