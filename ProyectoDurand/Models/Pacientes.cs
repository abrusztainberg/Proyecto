using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Durand.Models
{
    public class Pacientes
    {
        public int ID_Paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ObraSocial { get; set; }
        public int NroAfiliado { get; set; }
        public string Habitacion { get; set; }
    }
}