namespace Model
{

    //ver como funciona depois a questao da separacao

    public class Item
    {
        public int ItemId { get; set; }
        public Apartment? Apartment { get; set; }
        public House? House { get; set; }
        public List<Address> Addresses { get; set; } = new();

        public Item()
        {
            Addresses.Add(new Address());
        }

    }
}
