using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{   
    public class Filiais : BaseEntity<int>
    {
        public Filiais() {
            Funcionarios = new HashSet<Funcionarios>();
            Departamentos = new HashSet<Departamentos>();
        }

        public Filiais(int id, string nome, string endereco, string telefone)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Funcionarios = new HashSet<Funcionarios>();
            Departamentos = new HashSet<Departamentos>();
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public ICollection<Funcionarios> Funcionarios { get; set; }
        public ICollection<Departamentos> Departamentos { get; set; }
    }
}
