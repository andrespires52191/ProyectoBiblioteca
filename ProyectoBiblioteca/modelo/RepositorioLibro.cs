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

        public bool ExisteTitulo(string titulo, int? idExcluir = null)
        {
            string sql = "SELECT COUNT(*) FROM LIBROS WHERE Titulo = @titulo";
            
            // Si se ha llegado desde la ventana de ModificarTitulo, se ignora el libro actual
            if (idExcluir.HasValue) sql += " AND ID != @id";

            SQLiteCommand cmd = new SQLiteCommand(sql);
            cmd.Parameters.Add("@titulo", DbType.String).Value = titulo;
            if (idExcluir.HasValue) cmd.Parameters.Add("@id", DbType.Int32).Value = idExcluir.Value;

            DataTable datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);

            return (datos.Rows.Count > 0 && Convert.ToInt32(datos.Rows[0][0]) > 0);
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

        public void ModificarLibro(int id, string titulo, string escritor, int? ano_edicion, string sinopsis, bool disponible)
        {
            string sql = "UPDATE LIBROS SET titulo=@titulo, escritor=@escritor, ano_edicion=@ano_edicion, sinopsis=@sinopsis, disponible=@disponible WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id", DbType.Int32).Value = id;
            cmd.Parameters.Add("@titulo", DbType.String).Value = titulo;
            cmd.Parameters.Add("@escritor", DbType.String).Value = escritor;
            cmd.Parameters.Add("@ano_edicion", DbType.Int32).Value = ano_edicion.HasValue ? (object)ano_edicion.Value : DBNull.Value;
            cmd.Parameters.Add("@sinopsis", DbType.String).Value = (object)sinopsis ?? DBNull.Value;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = disponible ? 1 : 0;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void ModificarDisponibilidad(int id, bool disponible)
        {
            string sql = "UPDATE LIBROS SET disponible=@disponible WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id", DbType.Int32).Value = id;
            cmd.Parameters.Add("@disponible", DbType.Int32).Value = disponible ? 1 : 0;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
    }
}
