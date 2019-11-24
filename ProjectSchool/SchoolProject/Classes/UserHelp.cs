using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Classes
{
    public class UserHelp
    {


        public UsuarioModel GetLoggedUser()
        {
            DBContext db = new DBContext();
            UsuarioModel usuario = db.UsuarioModel.Where(s => s.in_logging).FirstOrDefault();
            return usuario;

        }


    }
}