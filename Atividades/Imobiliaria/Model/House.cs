namespace Model
{
    public class House
    {
        public int Id { get; set; }
        public string Tittle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Price { get; set; }
        public List<Room> Room { get; set; } = new List<Room>();
        public BusinessType BusinessType { get; set; } = new BusinessType();
        public Address Address { get; set; } = new Address();

        public House(int id, string tittle, string description, string category, double price, List<Room> room, BusinessType businessType, Address address)
        { 
            Id = id;
            Tittle = tittle;
            Description = description;
            Category = category;
            Price = price;
            Room = room;
            BusinessType = businessType;
            Address = address;
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Tittle)) return false;
            if (string.IsNullOrEmpty(Description)) return false;
            if (string.IsNullOrEmpty(Category)) return false;
            if (Price <= 0) return false;
            if (string.IsNullOrEmpty(Room?.ToString())) return false;
            if (string.IsNullOrEmpty(BusinessType?.ToString())) return false;
            if (string.IsNullOrEmpty(Address?.ToString())) return false;

            return true;
        }
    }
}
