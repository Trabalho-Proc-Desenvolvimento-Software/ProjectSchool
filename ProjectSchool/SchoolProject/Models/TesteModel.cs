using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SchoolProject.Models
{
   
    public class TesteModel
    {
        [Key]
        public int cod_teste { get; set; }

        public string texto { get; set; }
    }
}