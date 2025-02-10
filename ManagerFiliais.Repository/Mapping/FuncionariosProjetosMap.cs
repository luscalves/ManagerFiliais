using ManagerFiliais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManagerFiliais.Repository.Mapping
{
    public class FuncionariosProjetosMap : IEntityTypeConfiguration<FuncionariosProjetos>
    {
        public void Configure(EntityTypeBuilder<FuncionariosProjetos> builder)
        {
            builder.ToTable("Funcionarios_Projetos");

            builder.HasKey(fp => fp.Id);

            builder.Property(fp => fp.CargoProjeto)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(fp => fp.DataParticipacao)
                .IsRequired()
                .HasColumnType("date");

            builder.HasOne<Funcionarios>()
                .WithMany()
                .HasForeignKey(fp => fp.IdFuncionario)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Projetos>()
                .WithMany()
                .HasForeignKey(fp => fp.IdProjeto)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}