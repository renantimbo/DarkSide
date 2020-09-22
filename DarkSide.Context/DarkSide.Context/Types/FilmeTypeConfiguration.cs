using DarkSide.Context.Models;
using System.Data.Entity.ModelConfiguration;

namespace DarkSide.Context.Types
{
    public class FilmeTypeConfiguration : EntityTypeConfiguration<Filme>
    {
        public FilmeTypeConfiguration()
        {
            HasKey(q => q.Id);

            Property(q => q.Nome).HasMaxLength(100);

            HasRequired(q => q.Genero).WithMany().HasForeignKey(q => q.IdGenero);
            
            HasRequired(q => q.Diretor).WithMany().HasForeignKey(q => q.IdDiretor);

        }
    }
}
