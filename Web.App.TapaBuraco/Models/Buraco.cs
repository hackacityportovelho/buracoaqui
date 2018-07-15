using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.App.TapaBuraco.Models
{
    public class Buraco
    {
        public Buraco()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
    }
}