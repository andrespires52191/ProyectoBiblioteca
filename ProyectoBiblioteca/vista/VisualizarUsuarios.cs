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

namespace ProyectoBiblioteca
{
    public partial class VisualizarUsuarios : Form
    {
        public Controlador miControlador {  get; set; }

        public VisualizarUsuarios()
        {
            InitializeComponent();
        }

        public static VisualizarUsuarios formulario;

        public static VisualizarUsuarios GetInstance()
        {
            if (formulario == null)
            {
                formulario = new VisualizarUsuarios();
            }
            return formulario;
        }

        private void pbVerBorrar_Click(object sender, EventArgs e)
        {
            Principal.GetInstance().MostrarGestionUsuarios();
        }
    }
}
