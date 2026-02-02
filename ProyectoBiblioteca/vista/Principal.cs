using ProyectoBiblioteca.controlador;
using ProyectoBiblioteca.vista;
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
        public Color colorPrincipalVerde = Color.FromArgb(0, 128, 99);
        public Color colorSecundarioVerde = Color.FromArgb(0, 153, 119);
        public Color colorContrasteBlanco = Color.FromArgb(255, 255, 255);

        public Principal()
        {
            InitializeComponent();
            MostrarInicio();
        }

        private void MostrarInicio()
        {
            pintarBotonClaro(bUsuarios);
            pintarBotonClaro(bLibros);
            pintarBotonClaro(bPrestamos);

            var form = VisualizarInicio.GetInstance();
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

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            pintarBotonClaro(bUsuarios);
            pintarBotonOscuro(bLibros);
            pintarBotonOscuro(bPrestamos);

            var form = VisualizarUsuarios.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void bLibros_Click(object sender, EventArgs e)
        {
            pintarBotonClaro(bLibros);
            pintarBotonOscuro(bUsuarios);
            pintarBotonOscuro(bPrestamos);

            var form = VisualizarLibros.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
        }

        private void bPrestamos_Click(object sender, EventArgs e)
        {
            pintarBotonClaro(bPrestamos);
            pintarBotonOscuro(bUsuarios);
            pintarBotonOscuro(bLibros);

            var form = VisualizarPrestamos.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
        }

        private void pintarBotonClaro(Button boton)
        {
            boton.ForeColor = colorPrincipalVerde;
            boton.BackColor = colorContrasteBlanco;
        }

        private void pintarBotonOscuro(Button boton)
        {
            boton.ForeColor = colorContrasteBlanco;
            boton.BackColor = colorSecundarioVerde;
        }
    }
}
