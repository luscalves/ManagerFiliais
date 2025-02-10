using ManagerFiliais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerFiliais.Repository.Mapping
{
    public class FuncionariosMap : IEntityTypeConfiguration<Funcionarios>
    {
        public void Configure(EntityTypeBuilder<Funcionarios> builder)
        {
            builder.ToTable("Funcionarios");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.Cargo)
                .HasMaxLength(100);

            builder.HasOne<Filiais>()
                .WithMany()
                .HasForeignKey(f => f.IdFilial)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}