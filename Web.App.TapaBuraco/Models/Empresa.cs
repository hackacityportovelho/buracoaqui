using System.Collections.Generic;

namespace Web.App.TapaBuraco.Models
{
    public class Empresa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Nire { get; set; }
        public string Enderco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        public ICollection<Representante> RepresentantecCollection { get; set; }
    }
}