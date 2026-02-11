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
