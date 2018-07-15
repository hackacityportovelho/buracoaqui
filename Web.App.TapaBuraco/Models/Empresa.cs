using System.Collections.Generic;
using System.ComponentModel;

namespace Web.App.TapaBuraco.Models
{
    public class Empresa
    {
        [DisplayName("Razão sócial")]
        public string RazaoSocial { get; set; }
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("NIRE")]
        public string Nire { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [DisplayName("Número")]
        public string Numero { get; set; }
        [DisplayName("Bairro")]
        public string Bairro { get; set; }
        [DisplayName("CEP")]
        public string Cep { get; set; }

        public ICollection<Representante> RepresentantecCollection { get; set; }
    }
}