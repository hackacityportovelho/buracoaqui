using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.App.TapaBuraco.Models
{
    public class Buraco
    {
        public Buraco()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "Descrição: (Opcional)")]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Informe a rua")]
        [Display(Name = "Rua: (Obrigatório)")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Informe o bairro")]
        [Display(Name = "Bairro: (Obrigatório)")]
        public string Bairro { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string UriFoto { get; set; }
        public bool Resolvido { get; set; }
        public Guid? IdEmpresa { get; set; }

    }
}