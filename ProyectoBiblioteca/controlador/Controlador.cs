using ProyectoBiblioteca.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.controlador
{
    public class Controlador
    {
        internal DataTable CargarLibros()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM LIBROS";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        internal DataTable CargarPrestamos()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM PRESTAMOS";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }

        internal DataTable CargarUsuarios()
        {
            DataTable datos = new DataTable();
            string sql = "SELECT * FROM USUARIOS";
            SQLiteCommand cmd = new SQLiteCommand(sql);
            datos = SQLiteHelper.GetDataTable(Properties.Settings.Default.conexion, cmd);
            return datos;
        }
    }
}
