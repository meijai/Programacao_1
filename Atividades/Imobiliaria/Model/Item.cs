namespace Model
{

    //ver como funciona depois a questao da separacao

    public class Item
    {
        public int Id { get; set; }
        public Apartment? Apartment { get; set; }
        public House? House { get; set; }

    }
}
