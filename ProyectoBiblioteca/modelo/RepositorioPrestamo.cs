using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.modelo
{
    public class RepositorioPrestamo
    {
        internal DataTable CargarTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM PRESTAMOS";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        public void AnadirPrestamo(Prestamo prestamo)
        {
            string sql = "INSERT INTO PRESTAMOS (id_libro, id_usuario, fecha_inicio, fecha_fin) VALUES (@id_libro, @id_usuario, @fecha_inicio, @fecha_fin)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id_libro", DbType.Int32).Value = prestamo.id_libro;
            cmd.Parameters.Add("@id_usuario", DbType.Int32).Value = prestamo.id_usuario;
            cmd.Parameters.Add("@fecha_inicio", DbType.String).Value = prestamo.fecha_inicio;
            cmd.Parameters.Add("@fecha_fin", DbType.String).Value = prestamo.fecha_fin;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void EliminarPrestamo(int id)
        {
            string sql = $"DELETE FROM PRESTAMOS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable BuscarPorID(int id)
        {
            DataTable datos = new DataTable();
            string sql = $"SELECT * FROM PRESTAMOS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }
    }
}
