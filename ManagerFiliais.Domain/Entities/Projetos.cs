using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{

    public class Projetos : BaseEntity<int>
    {
        public Projetos() { }

        public Projetos(int id, string nome, int idDepartamento, DateTime dataInicio, DateTime? dataFim)
        {
            Id = id;
            Nome = nome;
            IdDepartamento = idDepartamento;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public string Nome { get; set; }
        public int IdDepartamento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
