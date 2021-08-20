using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data.SqlClient;
using Proyecto_Durand.Models;

namespace Proyecto_Durand.Models
{
    public static class BD
    {
        private static string _connectionString = "Server=.; Database=dbdurand; Trusted_Connection=true;";
        private static MySqlConnection Conectar()
        {
            MySqlConnection con = new MySqlConnection(_connectionString);
            con.Open();
            return con;
        }

        private static bool Desconectar(MySqlConnection con)
        {
            bool pudoDesconectar = false;
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                pudoDesconectar = true;
            }
            return pudoDesconectar;
        }
        /*public static List<Usuario> Usuarios_TraerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            MySqlConnection con = Conectar();
            MySqlCommand consulta = con.CreateCommand();

            consulta.CommandText = "Usuarios_TraerTodos";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;

            MySqlDataReader lector = consulta.ExecuteReader();

            while (lector.Read())
            {
                string email = lector["Email"].ToString();
                string contraseña = lector["Contraseña"].ToString();
                //int id_usuario = Convert.ToInt32(lector["Id_Usuario"]);
                lista.Add(new Usuario(email, contraseña));
            }
            Desconectar(con);
            return lista;
        }
    }
        */
    }
}