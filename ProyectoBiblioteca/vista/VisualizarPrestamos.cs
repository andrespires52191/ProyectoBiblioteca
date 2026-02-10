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
    public partial class VisualizarPrestamos : Form
    {
        public Controlador miControlador { get; set; }

        public VisualizarPrestamos()
        {
            InitializeComponent();
        }

        public static VisualizarPrestamos formulario;

        public static VisualizarPrestamos GetInstance()
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new VisualizarPrestamos();
            }
            return formulario;
        }
        private void pbVerBorrar_Click(object sender, EventArgs e)
        {
            Principal.GetInstance().MostrarGestionPrestamos();
        }

        private void pbInsertar_Click(object sender, EventArgs e)
        {
            Principal.GetInstance().MostrarInsertarPrestamos();
        }
    }
}
