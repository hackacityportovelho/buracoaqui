using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.App.TapaBuraco.Models
{
    public class Prefeitura
    {
        public Prefeitura()
        {
            Id = new Guid();
        }
        [Key]
        public Guid Id { get; set; }
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