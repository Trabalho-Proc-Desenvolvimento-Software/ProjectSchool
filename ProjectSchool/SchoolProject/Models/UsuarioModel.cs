using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Models
{
    public class UsuarioModel
    {
        public int cod_usuario { get; set; }

        public string senha { get; set; } //senha em string msm fodac

        public bool in_logging { get; set; }
    }
}