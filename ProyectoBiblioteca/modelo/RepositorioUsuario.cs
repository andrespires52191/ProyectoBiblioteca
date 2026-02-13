using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.modelo
{
    public class RepositorioUsuario
    {
        internal DataTable CargarTodo()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM USUARIOS";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        public void AnadirUsuario(Usuario libro)
        {
            string sql = "INSERT INTO USUARIOS (nombre, apellido_1, apellido_2, telefono) VALUES (@nombre, @apellido_1, @apellido_2, @telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@nombre", DbType.String).Value = libro.nombre;
            cmd.Parameters.Add("@apellido_1", DbType.String).Value = libro.apellido_1;
            cmd.Parameters.Add("@apellido_2", DbType.String).Value = libro.apellido_2;
            cmd.Parameters.Add("@telefono", DbType.Int32).Value = libro.telefono;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public void EliminarUsuario(int id)
        {
            string sql = $"DELETE FROM USUARIOS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }

        public DataTable BuscarPorID(int id)
        {
            DataTable datos = new DataTable();
            string sql = $"SELECT * FROM USUARIOS WHERE ID={id}";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }
    }
}
