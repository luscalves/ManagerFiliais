using ManagerFiliais.Domain.Base;

namespace ManagerFiliais.Domain.Entities
{
    public class FuncionariosProjetos : BaseEntity<int>
    {
        public FuncionariosProjetos() { }

        public FuncionariosProjetos(int id, int idFuncionario, int idProjeto, string cargoProjeto, DateTime dataParticipacao)
        {
            Id = id;
            IdFuncionario = idFuncionario;
            IdProjeto = idProjeto;
            CargoProjeto = cargoProjeto;
            DataParticipacao = dataParticipacao;
        }

        public int IdFuncionario { get; set; }
        public int IdProjeto { get; set; }
        public string CargoProjeto { get; set; }
        public DateTime DataParticipacao { get; set; }

        public Funcionarios Funcionario { get; set; }
        public Projetos Projeto { get; set; }
    }
}