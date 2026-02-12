using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.modelo
{
    public class RepositorioLibro
    {
        internal DataTable CargarTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM LIBROS";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        public void AnadirLibro(Libro libro)
        {
            string sql = "INSERT INTO LIBROS (titulo, escritor, ano_edicion, sinopsis, disponible) VALUES (@titulo, @escritor, @ano_edicion, @sinopsis, @disponible)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@titulo", DbType.String).Value = libro.titulo;
            cmd.Parameters.Add("@escritor", DbType.String).Value = libro.escritor;
            cmd.Parameters.Add("@ano_edicion", DbType.Int32).Value = libro.ano_edicion;
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = libro.sinopsis;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = libro.disponible;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void EliminarLibro(int id)
        {
            string sql = $"DELETE FROM LIBROS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable BuscarPorID(int id)
        {
            DataTable datos = new DataTable();
            string sql = $"SELECT * FROM LIBROS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }
    }
}
