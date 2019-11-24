using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolProject.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("SchoolDb")
        {

        }

        public System.Data.Entity.DbSet<SchoolProject.Models.TesteModel> TesteModels { get; set; }
        public System.Data.Entity.DbSet<SchoolProject.Models.UsuarioModel> UsuarioModel { get; set; }
    }
}