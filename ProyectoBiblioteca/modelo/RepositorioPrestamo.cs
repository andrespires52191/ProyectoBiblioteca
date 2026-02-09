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
    }
}
