namespace ManagerFiliais.App.Models
{
    public class FuncionariosProjetosModel
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public int IdProjeto { get; set; }
        public string CargoProjeto { get; set; }
        public DateTime DataParticipacao { get; set; }
    }
}