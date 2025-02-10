using ManagerFiliais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerFiliais.Repository.Mapping
{
    public class FiliaisMap : IEntityTypeConfiguration<Filiais>
    {
        public void Configure(EntityTypeBuilder<Filiais> builder)
        {
            builder.ToTable("Filiais");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.Endereco)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(f => f.Telefone)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}