using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{
    public class Usuarios : BaseEntity<int>
    {
        public Usuarios() { }

        public Usuarios(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}