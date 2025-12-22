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
    public partial class Principal : Form
    {
        public Controlador miControlador = new Controlador();

        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = VisualizarUsuarios.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
        }

        private void InsertarFormulario(Form formulario)
        {
            // Comprobar si hay un formulario MDI activo
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
    }
}
