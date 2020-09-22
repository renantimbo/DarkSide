namespace DarkSide.Context.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public int IdDiretor { get; set; }
        public string Nome { get; set; }

        public Diretor Diretor { get; set; }
        public Genero Genero { get; set; }
    }
}
