using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Autores
    {
        private int codigoAutor;
        private string nombre;
        private DateTime fechaNacimiento;
        private string nacionalidad;

        public int CodigoAutor { get => codigoAutor; set => codigoAutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

        public static DataTable CargarAutores()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "Select * from Autores_Lista";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }

        public bool InsertarAutor()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = "INSERT INTO Autor (nombre, fechaNacimiento, nacionalidad) " +
                "VALUES (@Nombre, @FechaNacimiento, @Nacionalidad)";
            SqlCommand cmd = new SqlCommand(comando, conexion);

            //Parametros de modificacion
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@Nacionalidad", Nacionalidad);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool EliminarAutor()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = "DELETE FROM Autor WHERE CodigoAutor = @CodigoAutor";
            SqlCommand cmd = new SqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@CodigoAutor", codigoAutor);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable BuscarAutor(string termino)
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM Autores_Lista WHERE [Nombre del Autor] LIKE @termino";
            SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
            cmd.Parameters.AddWithValue("@termino", "%" + termino + "%");
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }
    }
}
