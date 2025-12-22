using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_biblioteca.modelo
{
    internal class Libro
    {
        public Libro()
        {
        }

        public Libro(int libro_id, string titulo, string autor, string isbn, string editorial, DateTime anio_publicacion, string idioma, string categoria, string ubicacion, int total_ejemplares, int ejemplares_disponibles)
        {
            Libro_id = libro_id;
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            Editorial = editorial;
            Anio_publicacion = anio_publicacion;
            Idioma = idioma;
            Categoria = categoria;
            Ubicacion = ubicacion;
            Total_ejemplares = total_ejemplares;
            Ejemplares_disponibles = ejemplares_disponibles;
        }

        private int Libro_id { get; set; }
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string Isbn { get; set; }
        private string Editorial { get; set; }
        private DateTime Anio_publicacion { get; set; }
        private string Idioma { get; set; }
        private string Categoria { get; set; }
        private string Ubicacion { get; set; }
        private int Total_ejemplares { get; set; }
        private int Ejemplares_disponibles { get; set; }
    }
}
