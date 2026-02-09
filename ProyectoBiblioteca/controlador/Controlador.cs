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

        internal DataTable CargarLibros()
        {
            return repoLibro.CargarTodo();
        }

        internal DataTable CargarPrestamos()
        {
            return repoPrestamo.CargarTodo();
        }

        internal DataTable CargarUsuarios()
        {
            return repoUsuario.CargarTodo();
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
    }
}
