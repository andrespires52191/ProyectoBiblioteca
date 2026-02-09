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
    public partial class VisualizarLibros : Form
    {
        public Controlador miControlador { get; set; }

        public VisualizarLibros()
        {
            InitializeComponent();
        }

        public static VisualizarLibros formulario;

        public static VisualizarLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new VisualizarLibros();
            }
            return formulario;
        }

        private void pbVerBorrar_Click(object sender, EventArgs e)
        {
            Principal.GetInstance().MostrarGestionLibros();
        }

        private void pbInsertar_Click(object sender, EventArgs e)
        {
            Principal.GetInstance().MostrarInsertarLibros();
        }
    }
}
