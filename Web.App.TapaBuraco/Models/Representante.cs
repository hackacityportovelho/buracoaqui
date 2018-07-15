namespace Web.App.TapaBuraco.Models
{
    public class Representante
    {
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string Naturidade { get; set; }
        public string EstadoCivil { get; set; }
        public string Profissao { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public Empresa Empresa { get; set; }
    }
}