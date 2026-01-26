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
    public partial class VisualizarInicio : Form
    {
        public Controlador miControlador { get; set; }

        public VisualizarInicio()
        {
            InitializeComponent();
        }

        public static VisualizarInicio formulario;

        public static VisualizarInicio GetInstance()
        {
            if (formulario == null)
            {
                formulario = new VisualizarInicio();
            }
            return formulario;
        }

        private void tlpSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpInferior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
