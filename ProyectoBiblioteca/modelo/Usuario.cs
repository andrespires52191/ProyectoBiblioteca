using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.modelo
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido_1 { get; set; }
        public string apellido_2 { get; set; }
        public int telefono { get; set; }

        public Usuario(string nombre, string apellido_1, string apellido_2, int telefono) {
            this.nombre = nombre;
            this.apellido_1 = apellido_1;
            this.apellido_2 = apellido_2;
            this.telefono = telefono;
        }
    }
}
