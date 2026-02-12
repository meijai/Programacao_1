namespace Exemplo_01.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Especie { get; set; } = null!;
        public string Raca { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
    }
}
