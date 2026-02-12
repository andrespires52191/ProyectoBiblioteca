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
        public RepositorioLibro repoLibro = new RepositorioLibro();
        public RepositorioPrestamo repoPrestamo = new RepositorioPrestamo();
        public RepositorioUsuario repoUsuario = new RepositorioUsuario();


        //
        // Libros
        //

        internal DataTable CargarLibros()
        {
            return repoLibro.CargarTodo();
        }
        public void AnadirLibro(string titulo, string escritor, int ano_edicion, string sinopsis, bool disponible)
        {
            if (titulo == "" || escritor == "" || sinopsis == "")
            {
                throw new Exception("Debes rellenar los datos correctamente");
            }
            Libro miLibro = new Libro(titulo, escritor, ano_edicion, sinopsis, disponible);
            repoLibro.AnadirLibro(miLibro);
        }
        public DataTable BuscarLibro(int id)
        {
            return repoLibro.BuscarPorID(id);
        }
        public void EliminarLibro(int id)
        {
            repoLibro.EliminarLibro(id);
        }

        //
        // Prestamos
        //

        internal DataTable CargarPrestamos()
        {
            return repoPrestamo.CargarTodo();
        }
        public void AnadirPrestamo(int id_usuario, int id_libro, DateTime fecha_prestamo, DateTime fecha_devolucion)
        {
            if (id_usuario == 0 || id_libro == 0)
            {
                throw new Exception("Debes rellenar los datos correctamente");
            }
            repoPrestamo.AnadirPrestamo(new Prestamo(id_usuario, id_libro, fecha_prestamo.ToString("yyyy-MM-dd"), fecha_devolucion.ToString("yyyy-MM-dd")));
        }
        public DataTable BuscarPrestamo(int id)
        {
            return repoPrestamo.BuscarPorID(id);
        }
        public void EliminarPrestamo(int id)
        {
            repoPrestamo.EliminarPrestamo(id);
        }

        //
        // Usuarios
        //
        internal DataTable CargarUsuarios()
        {
            return repoUsuario.CargarTodo();
        }
        public void AnadirUsuario(string nombre, string apellido_1, string apellido_2, int telefono)
        {
            if (nombre == "" || apellido_1 == "" || apellido_2 == "" || telefono == 0)
            {
                throw new Exception("Debes rellenar los datos correctamente");
            }
            repoUsuario.AnadirUsuario(new Usuario(nombre, apellido_1, apellido_2, telefono));
        }
        public DataTable BuscarUsuario(int id)
        {
            return repoUsuario.BuscarPorID(id);
        }
        public void EliminarUsuario(int id)
        {
            repoUsuario.EliminarUsuario(id);
        }
    }
}
