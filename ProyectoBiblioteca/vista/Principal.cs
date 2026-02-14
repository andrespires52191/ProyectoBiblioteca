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

        static private Principal principal;
        static public Principal GetInstance() => principal;

        public Principal()
        {
            InitializeComponent();
            principal = this;
            MostrarInicio();
        }

        public void InsertarFormulario(Form formulario)
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

        private void MostrarInicio()
        {
            pintarBotonClaro(bUsuarios);
            pintarBotonClaro(bLibros);
            pintarBotonClaro(bPrestamos);

            var form = VisualizarInicio.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
            lTitulo.Text = "Biblioteca";
        }

        internal void MostrarGestionLibros()
        {
            var gestionLibros = GestionLibros.GetInstance();
            gestionLibros.miControlador = miControlador;
            InsertarFormulario(gestionLibros);
            gestionLibros.Cargar(miControlador.CargarLibros());
        }

        internal void MostrarGestionPrestamos()
        {
            var gestionPrestamos = GestionPrestamos.GetInstance();
            gestionPrestamos.miControlador = miControlador;
            InsertarFormulario(gestionPrestamos);
            gestionPrestamos.Cargar(miControlador.CargarPrestamos());
        }

        internal void MostrarGestionUsuarios()
        {
            var gestionUsuarios = GestionUsuarios.GetInstance();
            gestionUsuarios.miControlador = miControlador;
            InsertarFormulario(gestionUsuarios);
            gestionUsuarios.Cargar(miControlador.CargarUsuarios());
        }

        internal void MostrarInsertarLibros()
        {
            var gestionLibros = InsertarLibros.GetInstance();
            gestionLibros.miControlador = miControlador;
            InsertarFormulario(gestionLibros);
        }

        internal void MostrarInsertarPrestamos()
        {
            var gestionPrestamos = InsertarPrestamos.GetInstance();
            gestionPrestamos.miControlador = miControlador;
            gestionPrestamos.CargarLibros(miControlador.CargarLibros());
            gestionPrestamos.CargarUsuarios(miControlador.CargarUsuarios());
            InsertarFormulario(gestionPrestamos);
        }

        internal void MostrarInsertarUsuarios()
        {
            var gestionUsuarios = InsertarUsuarios.GetInstance();
            gestionUsuarios.miControlador = miControlador;
            InsertarFormulario(gestionUsuarios);
        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            pintarBotonClaro(bUsuarios);
            pintarBotonOscuro(bLibros);
            pintarBotonOscuro(bPrestamos);

            var form = VisualizarUsuarios.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
            lTitulo.Text = "Usuarios";
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
            lTitulo.Text = "Libros";
        }

        private void bPrestamos_Click(object sender, EventArgs e)
        {
            pintarBotonClaro(bPrestamos);
            pintarBotonOscuro(bUsuarios);
            pintarBotonOscuro(bLibros);

            var form = VisualizarPrestamos.GetInstance();
            form.miControlador = miControlador;
            InsertarFormulario(form);
            lTitulo.Text = "Préstamos";
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
