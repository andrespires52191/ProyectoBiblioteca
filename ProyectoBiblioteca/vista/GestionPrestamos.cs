using ProyectoBiblioteca.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.vista
{
    public partial class GestionPrestamos : Form
    {
        public Controlador miControlador { get; set; }

        public GestionPrestamos()
        {
            InitializeComponent();
        }

        public static GestionPrestamos formulario;
        internal static GestionPrestamos GetInstance()
        {
            if (formulario == null)
            {
                formulario = new GestionPrestamos();
            }
            return formulario;
        }

        internal void Cargar(DataTable dataTable)
        {
            throw new NotImplementedException();
        }
    }
}
