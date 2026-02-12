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

        /*
        public void AnadirLibro(string titulo, string escritor, int ano_edicion, string sinopsis, bool disponible)
        {
            if (titulo == "" || escritor == "" || sinopsis == "")
            {
                throw new Exception("Debes rellenar los datos correctamente");
            }

            Libro miLibro = new Libro(titulo, escritor, ano_edicion, sinopsis, disponible);
            repoLibro.AnadirLibro(miLibro);
        }
        */

        public bool ExisteTitulo(string titulo)
        {
            return repoLibro.ExisteTitulo(titulo);
        }

        // Método de validación que lanza excepciones con mensajes claros
        public void ValidarDatosLibro(string titulo, string escritor, int? ano_edicion, string sinopsis, bool disponible)
        {
            // 1. Validar Título (NOT NULL)
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new Exception("El título es obligatorio.");
            }

            // 2. Validar Título UNIQUE (comprobar en BD)
            if (ExisteTitulo(titulo))
            {
                throw new Exception("Este título ya existe en la biblioteca.");
            }

            // 3. Validar Escritor - Ya lo hace la vista

            // 4. Validar Año de edición (INTEGER, puede ser NULL)
            if (ano_edicion.HasValue)
            {
                int anioActual = DateTime.Now.Year;
                if (ano_edicion.Value < 0 || ano_edicion.Value > anioActual)
                {
                    throw new Exception($"El año de edición debe estar entre 0 y {anioActual}.");
                }
            }

            // 5. Validar Sinopsis (TEXT, puede ser NULL, máximo 2000 caracteres)
            if (sinopsis != null && sinopsis.Length > 2000)
            {
                throw new Exception("La sinopsis no puede superar los 2000 caracteres.");
            }

            // 6. Validar Disponible — El bool ya lo garantiza
        }

        public void AnadirLibro(string titulo, string escritor, int? ano_edicion, string sinopsis, bool disponible)
        {
            // Primero validar todos los datos
            ValidarDatosLibro(titulo, escritor, ano_edicion, sinopsis, disponible);

            // Si la validación pasa, crear el libro y añadirlo
            string escritorFinal = string.IsNullOrWhiteSpace(escritor) ? "Anonimo" : escritor;
            Libro miLibro = new Libro(titulo, escritorFinal, ano_edicion, sinopsis, disponible);
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

        public void ModificarLibro(int id, string titulo, string escritor, int ano_edicion, string sinopsis, bool disponible)
        {
            repoLibro.ModificarLibro(id, titulo, escritor, ano_edicion, sinopsis, disponible);
        }

        //
        // Usuarios
        //
        internal DataTable CargarUsuarios()
        {
            return repoUsuario.CargarTodo();
        }
        public DataTable BuscarUsuario(int id)
        {
            return repoUsuario.BuscarPorID(id);
        }
        public void EliminarUsuario(int id)
        {
            repoUsuario.EliminarUsuario(id);
        }

        //
        // Prestamos
        //

        internal DataTable CargarPrestamos()
        {
            return repoPrestamo.CargarTodo();
        }

        public DataTable BuscarPrestamo(int id)
        {
            return repoPrestamo.BuscarPorID(id);
        }

        public void EliminarPrestamo(int id)
        {
            repoPrestamo.EliminarPrestamo(id);
        }
    }
}
