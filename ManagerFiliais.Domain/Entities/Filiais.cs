using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{

    public class Filiais : BaseEntity<int>
    {
        public Filiais() { }

        public Filiais(int id, string nome, string endereco, string telefone)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}