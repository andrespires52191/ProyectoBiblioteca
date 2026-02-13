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

        public bool ExisteTitulo(string titulo)
        {
            string sql = "SELECT COUNT(*) FROM LIBROS WHERE Titulo = @titulo";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@titulo", DbType.String).Value = titulo;
            DataTable datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);

            if (datos.Rows.Count > 0)
            {
                int count = Convert.ToInt32(datos.Rows[0][0]);
                return count > 0;
            }
            return false;
        }

        public void AnadirLibro(Libro libro)
        {
            string sql = "INSERT INTO LIBROS (titulo, escritor, ano_edicion, sinopsis, disponible) VALUES (@titulo, @escritor, @ano_edicion, @sinopsis, @disponible)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@titulo", DbType.String).Value = libro.titulo;
            cmd.Parameters.Add("@escritor", DbType.String).Value = libro.escritor;
            cmd.Parameters.Add("@ano_edicion", DbType.Int32).Value = libro.ano_edicion.HasValue ? (object)libro.ano_edicion.Value : DBNull.Value;
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = (object)libro.sinopsis ?? DBNull.Value;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = libro.disponible ? 1 : 0;

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

        public void EliminarLibro(int id)
        {
            string sql = $"DELETE FROM LIBROS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void ModificarLibro(int id, string titulo, string escritor, int ano_edicion, string sinopsis, bool disponible)
        {
            // TODO
        }
    }
}
