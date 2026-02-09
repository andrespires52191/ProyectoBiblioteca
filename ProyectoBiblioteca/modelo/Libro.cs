using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.modelo
{
    public class Libro
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string escritor { get; set; }
        public int ano_edicion { get; set; }
        public string sinopsis { get; set; }
        public bool disponible { get; set; }

        public Libro(string titulo, string escritor, int ano_edicion, string sinopsis, bool disponible)
        {
            this.titulo = titulo;
            this.escritor = escritor;
            this.ano_edicion = ano_edicion;
            this.sinopsis = sinopsis;
            this.disponible = disponible;
        }
    }
}
