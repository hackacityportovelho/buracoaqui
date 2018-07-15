using System.ComponentModel;

namespace Web.App.TapaBuraco.Models
{
    public class Representante
    {
        [DisplayName("Cargo")]
        public string Cargo { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [DisplayName("Naturidade")]
        public string Naturidade { get; set; }
        [DisplayName("Estado civil")]
        public string EstadoCivil { get; set; }
        [DisplayName("Profissão")]
        public string Profissao { get; set; }
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        [DisplayName("RG")]
        public string Rg { get; set; }

        public Empresa Empresa { get; set; }
    }
}