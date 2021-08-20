using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Durand.Models
{
    public class HistoriaClinica
    {
        public int ID_Paciente { get; set; }
        public DateTime Fecha_Actual { get; set; }
        public int PA { get; set; }
        public int PH { get; set; }
        public int T { get; set; }
        public int IMC { get; set; }
        public int Tiempo { get; set; }
        public int NRS { get; set; }
        public int VGS { get; set; }
        public int Dinamometria { get; set; }
        public int MNA { get; set; }
        public int Strongkids { get; set; }
        public int RiesgoSme { get; set; }
        public int Requerimientos { get; set; }
        public int Energía { get; set; }
        public int Proteinas { get; set; }
        public int SintomasGI { get; set; }
        public int Apetito { get; set; }
        public int DentaduraFuncional { get; set; }
        public int Catartico { get; set; }
        public int Proquinetico { get; set; }
        public int Suplemento { get; set; }
        public int Comida { get; set; }
        public int DiasInternacion { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaObito { get; set; }
        public string Antecedentes { get; set; }
    }
}