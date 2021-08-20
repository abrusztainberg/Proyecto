using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using Proyecto_Durand.Models;
using System.Data.Sql;

namespace Proyecto_Durand.Controllers
{
    public class HomeController : Controller
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        [HttpGet]
        public ActionResult Index(string email, string contraseña)
        {
            ViewBag.tituloPrincipal = "NUTRICIÓN DURAND";
            ViewBag.volverNO = "NO";
            ViewBag.cerrarNO = "NO";
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = @"server=127.0.0.1;uid=root;pwd=;database=dbdurand;SSL Mode=None";
        }
        public ActionResult Verify(Usuario usuario)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from usuarios where email='" + usuario.Email + "' and contraseña='" + usuario.Contraseña + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (usuario.Email == "nutricion@gmail.com")
                {
                    con.Close();
                    ViewBag.tituloPrincipal = "NUTRICIÓN DURAND";
                    return View("salasNutri");
                }
                else if (usuario.Email == "comedor@gmail.com")
                {
                    con.Close();
                    ViewBag.comedor = "NO";
                    ViewBag.tituloPrincipal = "NUTRICIÓN DURAND";
                    return View("salasComedor");
                }
                return ViewBag.funciono = "si";
            }
            else
            {
                con.Close();
                ViewBag.cerrarNo = "NO";
                ViewBag.tituloPrincipal = "NUTRICIÓN DURAND";
                ViewBag.error = "si";
                ViewBag.volverNO = "NO";
                return View("Index");
            }
        }
        public ActionResult AgregarCama(Cama cama)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "Insert into dbdurand.camas(Desayuno_Merienda, Mama, R1, Dos, DosA, DosB, Tres, Cuatro, Cinco, Ind, Sonda, Edad) values('" + cama.Desayuno_Merienda + "', '" + cama.Mama + "', '" + cama.R1 + "', '" + cama.Dos + "', '" + cama.DosA + "', '" + cama.DosB + "', '" + cama.Tres + "', '" + cama.Cuatro + "', '" + cama.Cinco + "','" + cama.Ind + "', '" + cama.Sonda + "', " + cama.Edad + ")";
            int Devolver = com.ExecuteNonQuery();
            if (Devolver != -1)
            {
                con.Close();
                return View("pediatria");
            }
            else
            {
                con.Close();
                return View("Error");
            }
        }

        public ActionResult salasComedor()
        {
            ViewBag.tituloPrincipal = "NUTRICIÓN DURAND";
            ViewBag.volverNO = "NO";
            return View();
        }
        public ActionResult salas()
        {
            return View();
        }
        public ActionResult salasNutri()
        {
            ViewBag.tituloPrincipal = "NUTRICIÓN DURAND";
            ViewBag.volverNO = "NO";
            return View();
        }
        public ActionResult cardiologia()
        {
            ViewBag.tituloPrincipal = "CARDIOLOGÍA";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            ViewBag.aclaraciones = "ACLARACIONES: En los DESAYUNOS y MERIENDAS dar TÉ o MATE COCIDO CON O SIN LECHE según lo solicite el/la paciente, con excepción de aclaraciones realizadas por el Lic.en Nutrición.//En VD enviar 2 tenedores.// ¡¡Todos los R sin sal agregar limón en alm y cena!!";
            return View("salas");
        }
        public ActionResult clinica3ero()
        {
            ViewBag.tituloPrincipal = "CLÍNICA 3RO";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "1";
            ViewBag.dos = "LIQ";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "SN";
            return View("salas");
        }
        public ActionResult guardia()
        {
            ViewBag.tituloPrincipal = "GUARDIA";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            return View("salas");
        }
        public ActionResult uco()
        {
            ViewBag.tituloPrincipal = "UCO";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            ViewBag.aclaraciones = "ACLRACIONES: DESAYUNO y MERIENDA: dar TÉ o MATE COCIDO CON O SIN LECHE según lo solicite el/la paciente, con excepción de aclaraciones del Lic.en Nutricion. En VD enviar 2 tenedores.// Los R sin sal agregar Limon en alm y cena.";
            return View("salas");
        }
        public ActionResult utip()
        {
            ViewBag.tituloPrincipal = "UTIP";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "MAMA";
            ViewBag.dos = "R1";
            ViewBag.tres = "2";
            ViewBag.cuatro = "2A";
            ViewBag.cinco = "2B";
            ViewBag.seis = "3";
            ViewBag.siete = "4";
            ViewBag.ocho = "5";
            ViewBag.nueve = "IND";
            ViewBag.diez = "Sonda";
            ViewBag.once = "Edad/Peso";
            return View("utip");
        }
        public ActionResult cirugia()
        {
            ViewBag.tituloPrincipal = "CIRUGÍA";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "LIQ";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "SN";
            return View("salas");
        }
        public ActionResult geriatria()
        {
            ViewBag.tituloPrincipal = "GERIATRÍA";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "1";
            ViewBag.dos = "LIQ";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "SN";
            ViewBag.aclaraciones = "ACLARACIONES: en todos los regimenes por más que digan hiposódicos entregar un sobre de sal. Entregar 2 tenedores en las vajillas descartables!!! Recordar entregar un vaso con cada comida.";
            return View("salas");
        }
        public ActionResult maternidad()
        {
            ViewBag.tituloPrincipal = "MATERNIDAD";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            return View("salas");
        }
        public ActionResult uti()
        {
            ViewBag.tituloPrincipal = "UTI";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            ViewBag.diez = "HS Sonda";
            ViewBag.once = "Anotaciones";

            return View("uti");
        }
        public ActionResult totalizacion()
        {
            ViewBag.tituloPrincipal = "TOTALIZACIÓN";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "DESC";
            ViewBag.diez = "D10HS";
            ViewBag.once = "NADA";
            return View("totalizacion");
        }
        public ActionResult clinica2do()
        {
            ViewBag.tituloPrincipal = "CLÍNICA 2DO";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            return View("salas");
        }
        public ActionResult ginecologia()
        {
            ViewBag.tituloPrincipal = "GINECOLOGÍA";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "R1";
            ViewBag.dos = "2";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "Sonda";
            return View("salas");
        }
        public ActionResult pediatria(Cama cama)
        {
            ViewBag.tituloPrincipal = "PEDIATRÍA";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "MAMA";
            ViewBag.dos = "R1";
            ViewBag.tres = "2";
            ViewBag.cuatro = "2A";
            ViewBag.cinco = "2B";
            ViewBag.seis = "3";
            ViewBag.siete = "4";
            ViewBag.ocho = "5";
            ViewBag.nueve = "IND";
            ViewBag.diez = "Sonda";
            ViewBag.once = "Edad";
            ViewBag.aclaraciones = "ACLARACIONES: menor o igual a 5 años no enviar carne picada. En DESAYUNO y MERIENDA dar TÉ o MATE c/ o s/ LECHE según lo solicite el/la paciente, excepto que haya aclaraciones. En VD dejar 2 tenedores.";
            ViewBag.cama = cama;
            return View("pediatria");
        }
        public ActionResult utim()
        {
            ViewBag.tituloPrincipal = "UTIM";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "1";
            ViewBag.dos = "LIQ";
            ViewBag.tres = "2A";
            ViewBag.cuatro = "2B";
            ViewBag.cinco = "3";
            ViewBag.seis = "4";
            ViewBag.siete = "5";
            ViewBag.ocho = "IND";
            ViewBag.nueve = "SN";
            return View("salas");
        }

        public ActionResult resumenPacientes()
        {
            ViewBag.tituloPrincipal = "RESUMEN PACIENTES";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "Nombre";
            ViewBag.dos = "Edad";
            ViewBag.tres = "Fecha de ingreso";
            ViewBag.cuatro = "Fecha de alta/óbito";
            ViewBag.cinco = "Días internación";
            ViewBag.seis = "Diagnósticos";
            ViewBag.siete = "Sala";
            ViewBag.ocho = "PA";
            ViewBag.nueve = "PH";
            ViewBag.diez = "T";
            ViewBag.once = "IMC";
            ViewBag.doce = "%PP";
            ViewBag.trece = "Tiempo";
            ViewBag.catorce  = "NRS";
            ViewBag.quince = "VGS";
            ViewBag.dieciseis = "Dinamometría";
            ViewBag.diecisiete= "MNA";
            ViewBag.dieciocho = "Strong kids";
            ViewBag.diecinueve = "Riesgo SME";
            ViewBag.veinte = "Cantidad comida ingerida";
            return View();
        }
        public ActionResult resumenPacientesAltaObito()
        {
            ViewBag.tituloPrincipal = "RESUMEN PACIENTES";
            ViewBag.volver = "salasNutri";
            ViewBag.uno = "Nombre";
            ViewBag.dos = "Edad";
            ViewBag.tres = "Fecha de ingreso";
            ViewBag.cuatro = "Fecha de alta/óbito";
            ViewBag.cinco = "Días internación";
            ViewBag.seis = "Diagnósticos";
            ViewBag.siete = "Sala";
            ViewBag.ocho = "PA";
            ViewBag.nueve = "PH";
            ViewBag.diez = "T";
            ViewBag.once = "IMC";
            ViewBag.doce = "%PP";
            ViewBag.trece = "Tiempo";
            ViewBag.catorce = "NRS";
            ViewBag.quince = "VGS";
            ViewBag.dieciseis = "Dinamometría";
            ViewBag.diecisiete = "MNA";
            ViewBag.dieciocho = "Strong kids";
            ViewBag.diecinueve = "Riesgo SME";
            ViewBag.veinte = "Cantidad comida ingerida";
            return View();
        }
    }
}