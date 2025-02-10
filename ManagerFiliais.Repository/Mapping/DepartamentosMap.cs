using ManagerFiliais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerFiliais.Repository.Mapping
{
    public class DepartamentosMap : IEntityTypeConfiguration<Departamentos>
    {
        public void Configure(EntityTypeBuilder<Departamentos> builder)
        {
            builder.ToTable("Departamentos");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne<Filiais>()
                .WithMany()
                .HasForeignKey(d => d.IdFilial)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}