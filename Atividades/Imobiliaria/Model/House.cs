namespace Model
{
    public class House : Item
    {
        public int Id { get; set; }
        public string Tittle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public List<House> Houses { get; set; } = new();
        public List<Room> Room { get; set; } = new List<Room>();
        public BusinessType BusinessType { get; set; }
        public Address Address { get; set; } = new Address();

        public House()
        { 
        }

        public House(
            int id,
            string tittle,
            string description,
            double price,
            List<Room> room,
            BusinessType businessType,
            Address address
            )
        { 
            Id = id;
            Tittle = tittle;
            Description = description;
            Price = price;
            Room = room;
            BusinessType = businessType;
            Address = address;
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Tittle)) return false;
            if (string.IsNullOrEmpty(Description)) return false;
            if (Price <= 0) return false;
            if (string.IsNullOrEmpty(Room?.ToString())) return false;
            if (string.IsNullOrEmpty(BusinessType.ToString())) return false;
            if (string.IsNullOrEmpty(Address?.ToString())) return false;

            return true;
        }
    }
}
