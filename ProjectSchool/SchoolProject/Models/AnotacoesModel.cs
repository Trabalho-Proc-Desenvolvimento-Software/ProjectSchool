using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolProject.Models
{
    public class AnotacoesModel
    {
        [Key]
        public int cod_anotacao { get; set; }

        public string texto { get; set; }
        
    }
}