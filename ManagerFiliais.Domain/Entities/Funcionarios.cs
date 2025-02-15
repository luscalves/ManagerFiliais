using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{
    public class Funcionarios : BaseEntity<int>
    {
        public Funcionarios() { }

        public Funcionarios(int id, string nome, string cargo, int idFilial)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            IdFilial = idFilial;
        }

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int IdFilial { get; set; }

        public Filiais Filial { get; set; }
    }
}