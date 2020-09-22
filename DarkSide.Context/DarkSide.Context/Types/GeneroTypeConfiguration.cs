using DarkSide.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace DarkSide.Context.Types
{
    public class GeneroTypeConfiguration : EntityTypeConfiguration<Genero>
    {
        public GeneroTypeConfiguration()
        {
            HasKey(q => q.Id);

            Property(q => q.Nome).HasMaxLength(100);

            HasMany(q => q.Filmes).WithRequired().HasForeignKey(q => q.IdGenero);


        }
    }
}
