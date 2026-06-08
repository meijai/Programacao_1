namespace Model
{
    public class BusinessType
    {
        public int Id { get; set; }
        public string? Types { get; set; }
    }
    public enum Types
    {
        Buy,
        Sell,
        Rent
    }
}
