using ManagerFiliais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerFiliais.Repository.Mapping
{
    public class ProjetosMap : IEntityTypeConfiguration<Projetos>
    {
        public void Configure(EntityTypeBuilder<Projetos> builder)
        {
            builder.ToTable("Projetos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.DataInicio)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(p => p.DataFim)
                .HasColumnType("date");

            builder.HasOne<Departamentos>()
                .WithMany()
                .HasForeignKey(p => p.IdDepartamento)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}