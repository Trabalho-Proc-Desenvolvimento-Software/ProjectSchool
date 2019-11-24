using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectSchool.Models
{
    public class UsuarioModel
    {
        [Key]
        public int cod_usuario { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Tipo Uusário")]
        public UsuarioType UsuarioType { get; set; }


    }

    public enum UsuarioType
    {
        aluno,
        escola,
        pais
    }
}