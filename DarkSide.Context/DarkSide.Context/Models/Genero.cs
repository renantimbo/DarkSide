using System.Collections.Generic;

namespace DarkSide.Context.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Filme> Filmes { get; set; } = new HashSet<Filme>();
    }
}
