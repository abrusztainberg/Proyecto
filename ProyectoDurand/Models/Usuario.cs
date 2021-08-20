using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Durand.Models
{
    public class Usuario
    {
        //get-> obtener valor dela tributo  
        //set-> establece ese valor
        public int Id_Usuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int Id_Rol { get; set; }

        /*
        public Usuario(string Email, string Contraseña)
        {
            //_Id_Usuario = Id_Usuario;
            _Email = Email;
            _Contraseña = Contraseña;
        }
        */
    }
}