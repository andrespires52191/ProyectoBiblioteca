using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.modelo
{
    public class Prestamo
    {
        public int id { get; set; }
        public int id_libro { get; set; }
        public int id_usuario { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }

        public Prestamo(int id_usuario, int id_libro, string fecha_prestamo, string fecha_devolucion)
        {
            this.id_usuario = id_usuario;
            this.id_libro = id_libro;
            this.fecha_inicio = fecha_prestamo;
            this.fecha_fin = fecha_devolucion;
        }
    }
}
