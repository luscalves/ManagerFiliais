using ManagerFiliais.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace ManagerFiliais.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        // Entidades do sistema corporativo
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Filiais> Filiais { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Projetos> Projetos { get; set; }
        public DbSet<FuncionariosProjetos> FuncionariosProjetos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeamento das tabelas
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Filiais>().ToTable("Filiais");
            modelBuilder.Entity<Funcionarios>().ToTable("Funcionarios");
            modelBuilder.Entity<Departamentos>().ToTable("Departamentos");
            modelBuilder.Entity<Projetos>().ToTable("Projetos");
            modelBuilder.Entity<FuncionariosProjetos>().ToTable("Funcionarios_Projetos");

            // Configuração dos relacionamentos
            modelBuilder.Entity<Funcionarios>(entity =>
            {
                entity.HasOne<Filiais>()
                    .WithMany()
                    .HasForeignKey(f => f.IdFilial)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasOne<Filiais>()
                    .WithMany()
                    .HasForeignKey(d => d.IdFilial)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Projetos>(entity =>
            {
                entity.HasOne<Departamentos>()
                    .WithMany()
                    .HasForeignKey(p => p.IdDepartamento)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<FuncionariosProjetos>(entity =>
            {
                entity.HasOne<Funcionarios>()
                    .WithMany()
                    .HasForeignKey(fp => fp.IdFuncionario)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne<Projetos>()
                    .WithMany()
                    .HasForeignKey(fp => fp.IdProjeto)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(fp => fp.CargoProjeto)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(fp => fp.DataParticipacao)
                    .HasColumnType("date")
                    .IsRequired();
            });

            // Configuração de índices únicos
            modelBuilder.Entity<Usuarios>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Configuração de tamanhos de campos
            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(u => u.Nome).HasMaxLength(100);
                entity.Property(u => u.Email).HasMaxLength(100);
                entity.Property(u => u.Senha).HasMaxLength(255);
            });

            modelBuilder.Entity<Filiais>(entity =>
            {
                entity.Property(f => f.Nome).HasMaxLength(100);
                entity.Property(f => f.Endereco).HasMaxLength(255);
                entity.Property(f => f.Telefone).HasMaxLength(20);
            });
        }
    }
}