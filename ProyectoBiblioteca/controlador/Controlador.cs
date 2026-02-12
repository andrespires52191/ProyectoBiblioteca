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
        public void AnadirPrestamo(Prestamo prestamo)
        {
            repoPrestamo.AnadirPrestamo(prestamo);
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
        public void AnadirUsuario(Usuario usuario)
        {
            repoUsuario.AnadirUsuario(usuario);
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
