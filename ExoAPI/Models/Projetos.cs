namespace ExoAPI.Models
{
    public class Projetos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string DataDeInicio { get; set; }
        public string Tecnologias { get; set; }
        public string Requisitos { get; set; }
        public string Área { get; set; }
        public bool StatusDoProjeto { get; set; }
    }
}
