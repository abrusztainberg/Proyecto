using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Durand.Models
{
    public class Cama
    {
        public int Numero { get; set; }
        public int ID_Cama { get; set; }
        public string Desayuno_Merienda { get; set; }
        public string R1 { get; set; }
        public string Dos { get; set;  }
        public string DosA { get; set; }
        public string DosB { get; set; }
        public string Tres { get; set; }
        public string Cuatro { get; set; }
        public string Cinco { get; set; }
        public string Anotaciones { get; set; }
        public int ID_Paciente { get; set; }
        public int ID_Sala { get; set; }
        public string Sonda { get; set; }
        public int Sn { get; set; }
        public string Ind { get; set; }
        public string Mama { get; set; }
        public int Edad { get; set; }
        public int Hs_Sonda { get; set; }
        public float Peso { get; set; }

    
    public Cama(int _numero, int _idcama, string _desayunomerienda, string _R1, string _Dos, string _DosA, string _DosB, string _Tres, string _Cuatro, string _Cinco, string _anotaciones, int _idpaciente, int _idsala, string _sonda, int _Sn, string _ind, string _mama, int _edad, int _hssonda, int _peso)
    {
            Numero = _numero;
            ID_Cama = _idcama;
            Desayuno_Merienda = _desayunomerienda;
            R1 = _R1;
            Dos = _Dos;
            DosA = _DosA;
            DosB = _DosB;
            Tres = _Tres;
            Cuatro = _Cuatro;
            Cinco = _Cinco;
            Anotaciones = _anotaciones;
            ID_Paciente = _idpaciente;
            ID_Sala = _idsala;
            Sonda = _sonda;
            Sn = _Sn;
            Ind = _ind;
            Mama = _mama;
            Edad = _edad;
            Hs_Sonda = _hssonda;
            Peso = _peso;
    }
        public Cama()
        {

        }
}
}