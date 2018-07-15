using System.ComponentModel;

namespace Web.App.TapaBuraco.Models
{
    public class Prefeitura
    {
        [DisplayName("Prefeitura")]
        public string RazaoSocial { get; set; }
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Sede Administrativa")]
        public string SedeAdministrativa { get; set; }
        [DisplayName("Chefe do Poder Executivo")]
        public string ChefeDoPoderExecutivo { get; set; }
        [DisplayName("CPF")]
        public string Cpf { get; set; }
    }
}