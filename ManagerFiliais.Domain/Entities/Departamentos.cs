using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{
    public class Departamentos : BaseEntity<int>
    {
        public Departamentos() { }

        public Departamentos(int id, string nome, int idFilial)
        {
            Id = id;
            Nome = nome;
            IdFilial = idFilial;
        }

        public string Nome { get; set; }
        public int IdFilial { get; set; }

        public Filiais Filial { get; set; }
    }
}