namespace MedVet.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int Id_Animal { get; set; }
        public string? Date_Entrace { get; set; }
        public string? Date_Exit { get; set; }
        public string? Description { get; set; }
        public double Weight { get; set; }
        public int ID_Vet { get; set; }
        public int ID_Clinic { get; set; }
    }
}
