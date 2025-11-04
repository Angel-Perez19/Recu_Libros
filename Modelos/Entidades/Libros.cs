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
    public class Libros
    {
        private int codigoLibro;
        private string titulo;
        private int anioEdicion;
        private string ISBN;
        private int codigoAutor;
        private int codigoEditorial;
        private DateTime fecha;

        public int CodigoLibro { get => codigoLibro; set => codigoLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int AnioEdicion { get => anioEdicion; set => anioEdicion = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int CodigoAutor { get => codigoAutor; set => codigoAutor = value; }
        public int CodigoEditorial { get => codigoEditorial; set => codigoEditorial = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public static DataTable CargarEditoriales()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "Select * from Editorial";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }

        public static DataTable CargarVistazoGeneral()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "Select * from Libros_Vistazo";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }


        public static DataTable MostrarLibros()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "Select * from Libro";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }

        public int InsertarLibro()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = @"INSERT INTO Libro (titulo, anioEdicion, ISBN, codigoEditorial) 
                      VALUES (@Titulo, @AnioEdicion, @ISBN, @CodigoEditorial);
                      SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@Titulo", Titulo);
            cmd.Parameters.AddWithValue("@AnioEdicion", AnioEdicion);
            cmd.Parameters.AddWithValue("@ISBN", ISBN1);
            cmd.Parameters.AddWithValue("@CodigoEditorial", CodigoEditorial);

            // Ejecutar y obtener el ID del libro insertado
            int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            return nuevoId;
        }

        public bool InsertarLibroINNERJOIN(int codigoLibro)
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = "INSERT INTO Detalle_AutorLibro (codigoAutor, codigoLibro, Fecha) " +
                            "VALUES (@Autor, @Libro, @Fecha)";
            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@Autor", CodigoAutor);
            cmd.Parameters.AddWithValue("@Libro", codigoLibro); // Usar el ID obtenido
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static DataTable BuscarLibro(string termino)
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM Libros_Vistazo WHERE [Nombre del Autor] LIKE @termino";
            SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
            cmd.Parameters.AddWithValue("@termino", "%" + termino + "%");
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }

        public bool EliminarLibro()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = "DELETE FROM Libro WHERE codigoLibro = @CodigoLibro";
            SqlCommand cmd = new SqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@CodigoLibro", codigoLibro);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarLibro()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando = @"UPDATE Libro SET titulo = @Titulo, anioEdicion = @AnioEdicion, ISBN = @ISBN, codigoEditorial = @CodigoEditorial
              WHERE codigoLibro = @CodigoLibro;";
            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@Titulo", Titulo);
            cmd.Parameters.AddWithValue("@AnioEdicion", AnioEdicion);
            cmd.Parameters.AddWithValue("@ISBN", ISBN1);
            cmd.Parameters.AddWithValue("@CodigoEditorial", CodigoEditorial);
            cmd.Parameters.AddWithValue("@CodigoLibro", CodigoLibro);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static DataTable BuscarLibroModif(string termino)
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "SELECT * FROM Libro WHERE titulo LIKE @termino";
            SqlCommand cmd = new SqlCommand(consultaQuery, conexion);
            cmd.Parameters.AddWithValue("@termino", "%" + termino + "%");
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataTable dataTables = new DataTable();
            add.Fill(dataTables);
            return dataTables;
        }

    }
}
