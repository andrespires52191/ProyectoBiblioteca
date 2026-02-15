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

        public void AnadirUsuario(Usuario usuario)
        {
            string sql = "INSERT INTO USUARIOS (nombre, apellido_1, apellido_2, telefono) VALUES (@nombre, @apellido_1, @apellido_2, @telefono)";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@nombre", DbType.String).Value = usuario.nombre;
            cmd.Parameters.Add("@apellido_1", DbType.String).Value = usuario.apellido_1;
            // Gestión de nulos para Apellido_2
            cmd.Parameters.Add("@apellido_2", DbType.String).Value = (object)usuario.apellido_2 ?? DBNull.Value;
            cmd.Parameters.Add("@telefono", DbType.Int32).Value = usuario.telefono;

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

        public void ModificarUsuario(int id, string nombre, string apellido1, string apellido2, int telefono)
        {
            string sql = "UPDATE Usuarios SET Nombre=@nombre, Apellido_1=@apellido1, Apellido_2=@apellido2, Telefono=@telefono WHERE ID=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql);

            cmd.Parameters.Add("@id", DbType.Int32).Value = id;
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre;
            cmd.Parameters.Add("@apellido1", DbType.String).Value = apellido1;
            cmd.Parameters.Add("@apellido2", DbType.String).Value = (object)apellido2 ?? DBNull.Value;
            cmd.Parameters.Add("@telefono", DbType.Int32).Value = telefono;

            SQLiteHelper.Ejecuta(Properties.Settings.Default.conexion, cmd);
        }
    }
}
