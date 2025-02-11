namespace ManagerFiliais.App.Models
{
    public class ProjetosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdDepartamento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}