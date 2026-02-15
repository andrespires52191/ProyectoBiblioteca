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

        public DataTable CargarLibrosDisponibles()
        {
            return repoLibro.CargarDisponibles();
        }

        public bool ExisteTitulo(string titulo, int? idExcluir = null)
        {
            return repoLibro.ExisteTitulo(titulo, idExcluir);
        }

        // Método de validación que lanza excepciones con mensajes claros
        public void ValidarDatosLibro(string titulo, string escritor, int? ano_edicion, string sinopsis, bool disponible, int? idLibro = null)
        {
            // 1. Validar Título (NOT NULL)
            if (string.IsNullOrWhiteSpace(titulo))
            {
                throw new Exception("El título es obligatorio.");
            }

            // 2. Validar Título UNIQUE (comprobar en BD)
            // Pasar el idLibro para que no de error si el título es el mismo del libro que se está editando
            if (ExisteTitulo(titulo, idLibro))
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

        public void ModificarLibro(int id, string titulo, string escritor, int? ano_edicion, string sinopsis, bool disponible)
        {
            ValidarDatosLibro(titulo, escritor, ano_edicion, sinopsis, disponible, id);
            string escritorFinal = string.IsNullOrWhiteSpace(escritor) ? "Anonimo" : escritor;
            repoLibro.ModificarLibro(id, titulo, escritorFinal, ano_edicion, sinopsis, disponible);
        }

        public void ModificarDisponibilidadLibro(int id, bool disponible)
        {
            repoLibro.ModificarDisponibilidad(id, disponible);
        }

        //
        // Usuarios
        //

        internal DataTable CargarUsuarios()
        {
            return repoUsuario.CargarTodo();
        }

        public void ValidarDatosUsuario(string nombre, string apellido1, string telefono)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");
            
            if (string.IsNullOrWhiteSpace(apellido1))
                throw new Exception("El primer apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (!int.TryParse(telefono, out int numTelefono))
                throw new Exception("El teléfono debe contener solo números.");

            if (numTelefono <= 0 || telefono.Length != 9)
                throw new Exception("El teléfono debe ser un número válido de 9 dígitos.");
        }

        public void AnadirUsuario(string nombre, string apellido_1, string apellido_2, string telefono)
        {
            ValidarDatosUsuario(nombre, apellido_1, telefono);

            int numTelefono = int.Parse(telefono);
            string ap2Final = string.IsNullOrWhiteSpace(apellido_2) ? null : apellido_2;
            
            Usuario nuevoUsuario = new Usuario(nombre, apellido_1, ap2Final, numTelefono);
            repoUsuario.AnadirUsuario(nuevoUsuario);
        }

        public DataTable BuscarUsuario(int id)
        {
            return repoUsuario.BuscarPorID(id);
        }

        public void EliminarUsuario(int id)
        {
            repoUsuario.EliminarUsuario(id);
        }

        public void ModificarUsuario(int id, string nombre, string apellido1, string apellido2, string telefono)
        {
            ValidarDatosUsuario(nombre, apellido1, telefono);

            int numTelefono = int.Parse(telefono);
            repoUsuario.ModificarUsuario(id, nombre, apellido1, apellido2, numTelefono);
        }

        //
        // Préstamos
        //

        internal DataTable CargarPrestamos()
        {
            return repoPrestamo.CargarTodo();
        }

        public void AnadirPrestamo(int id_usuario, int id_libro, DateTime fecha_prestamo, DateTime fecha_devolucion)
        {
            if (id_usuario < 0 || id_libro < 0)
            {
                throw new Exception("Debes rellenar los datos correctamente.");
            }

            if (fecha_devolucion < fecha_prestamo)
            {
                throw new Exception("La fecha de devolución no puede ser anterior a la de préstamo.");
            }

            repoPrestamo.AnadirPrestamo(new Prestamo(id_usuario, id_libro, fecha_prestamo.ToString("yyyy-MM-dd"), fecha_devolucion.ToString("yyyy-MM-dd")));
            
            ModificarDisponibilidadLibro(id_libro, false);
        }

        internal void DevolverPrestamo(int id_prestamo)
        {
            // Buscar el préstamo para saber qué libro hay que liberar
            DataTable dt = repoPrestamo.BuscarPorID(id_prestamo);
            if (dt.Rows.Count > 0)
            {
                int id_libro = Convert.ToInt32(dt.Rows[0]["id_libro"]);

                // Eliminar el registro del préstamo
                repoPrestamo.EliminarPrestamo(id_prestamo);

                // Cambiar el estado del libro a disponible (True)
                ModificarDisponibilidadLibro(id_libro, true);
            }
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
