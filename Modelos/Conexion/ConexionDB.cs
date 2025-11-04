using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class ConexionDB
    {
        public static string servidor = "LAB03-OS-EQ010//SQLEXPRESS";

        public static string basededatos = "LIBROS_20240509";

        public static SqlConnection conectar()
        {
            string cadena = $"Data source ={servidor};Initial Catalog={basededatos};Integrated Security = true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            Console.WriteLine("Conexion Establecida Exitosamente");
            return conexion;
        }
    }
}
