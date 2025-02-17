using AutoMapper;
using ManagerFiliais.Domain.Entities;
using ManagerFiliais.Domain.Base;
using ManagerFiliais.Repository.Context;
using ManagerFiliais.Repository.Repository;
using ManagerFiliais.Service.Services;
using ManagerFiliais.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ManagerFiliais.App.Outros;
using ManagerFiliais.App.Cadastros;


namespace ManagerFiliais.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de dados

            var strCon = File.ReadAllText(@"C:\Faculdade\2024-2\ManagerPOE\ManagerFiliais\ManagerFiliais.App\Config\ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuarios>, BaseRepository<Usuarios>>();
            Services.AddScoped<IBaseRepository<Filiais>, BaseRepository<Filiais>>();
            Services.AddScoped<IBaseRepository<Funcionarios>, BaseRepository<Funcionarios>>();
            Services.AddScoped<IBaseRepository<Departamentos>, BaseRepository<Departamentos>>();
            Services.AddScoped<IBaseRepository<Projetos>, BaseRepository<Projetos>>();
            Services.AddScoped<IBaseRepository<FuncionariosProjetos>, BaseRepository<FuncionariosProjetos>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuarios>, BaseService<Usuarios>>();
            Services.AddScoped<IBaseService<Filiais>, BaseService<Filiais>>();
            Services.AddScoped<IBaseService<Funcionarios>, BaseService<Funcionarios>>();
            Services.AddScoped<IBaseService<Departamentos>, BaseService<Departamentos>>();
            Services.AddScoped<IBaseService<Projetos>, BaseService<Projetos>>();
            Services.AddScoped<IBaseService<FuncionariosProjetos>, BaseService<FuncionariosProjetos>>();
            #endregion

            #region Formulários
            // Adicione aqui os formulários necessários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroDepartamentos, CadastroDepartamentos>();
            Services.AddTransient<CadastroFuncionarios, CadastroFuncionarios>();
            Services.AddTransient<CadastroFuncionariosProjetos, CadastroFuncionariosProjetos>();
            Services.AddTransient<CadastroFiliais, CadastroFiliais>();
            Services.AddTransient<CadastroProjetos, CadastroProjetos>();
            Services.AddTransient<CadastroUsuarios, CadastroUsuarios>();


            #endregion

            #region Mappings
            // Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuarios, UsuariosModel>();
                config.CreateMap<Filiais, FiliaisModel>();
                config.CreateMap<Funcionarios, FuncionariosModel>();
                config.CreateMap<Departamentos, DepartamentosModel>();
                config.CreateMap<Projetos, ProjetosModel>();
                config.CreateMap<FuncionariosProjetos, FuncionariosProjetosModel>();
            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}