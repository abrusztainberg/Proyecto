using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Durand.Models
{
    public class Menus
    {
        public int Id_Menu { get; set; }
        public int Id_Menu_Predeterminado { get; set; }
        public string Tipo_Plato { get; set; }
        public string Observacion { get; set; }
    }
}