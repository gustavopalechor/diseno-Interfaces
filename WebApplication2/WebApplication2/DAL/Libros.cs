using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication2.Models;
using System.Configuration;
namespace WebApplication2.DAL
{
    public class Libros
    {
        private SqlConnection con;
        private void connection()
        {
            string constring =
            ConfigurationManager.ConnectionStrings["LibrosConn"].ToString();
            con = new SqlConnection(constring);
        }
        public bool AgregarLibros(Models.Libros libros)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AgregaLibros", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", libros.Titulo);
            cmd.Parameters.AddWithValue("@autor", libros.Autor);
            cmd.Parameters.AddWithValue("@paginas", libros.Paginas);
            cmd.Parameters.AddWithValue("@editorial", libros.Editorial);
            //Abrir la conexión
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}