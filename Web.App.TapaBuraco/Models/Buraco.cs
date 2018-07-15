﻿using System;
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
        }
        public Guid Id { get; set; }
        [Display(Name = "Descrição: (Opcional)")]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Informe a rua")]
        [Display(Name = "Rua: ()")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Informe o bairro")]
        public string Bairro { get; set; }
    }
}