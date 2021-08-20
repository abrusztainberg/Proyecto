using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Durand.Models
{
    public class PacientesXCamas
    {
        public int Id_Paciente { get; set; }
        public int Id_Cama { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Egreso { get; set; }
    }
}